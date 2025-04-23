using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using S7.Net;
using WindowsFormsApp1.Common;
using WindowsFormsApp1.Enum;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1 {
    public partial class Form1 : Form {
        #region 属性

        // 相机相关属性
        private readonly CameraControl _cameraControl = new CameraControl();

        // toolblock vpp
        private readonly string _toolBlockVppPath = Path.Combine(Application.StartupPath, "vpp/ToolBlock.vpp");

        // 控制子控件放大缩小的相关属性
        private readonly Dictionary<Control, ChildControlInfo> _controlInfos =
            new Dictionary<Control, ChildControlInfo>();

        private ChildControlInfo _childControlInfo;

        // 触发拍照的源头（第几次拍照）
        private PhotoTriggerSource _photoTriggerSource = PhotoTriggerSource.First;

        #endregion

        #region 构造函数

        public Form1() {
            InitializeComponent();
            InitializeChildControls();

            // 初始化listview
            Logger.Instance.Logs.ListChanged += LogListOnListChanged;
            listView1.Columns.Add("时间戳");
            listView1.Columns.Add("日志等级");
            listView1.Columns.Add("信息");
            Logger.Instance.AddLog("程序启动");
        }

        #endregion

        #region 方法

        // 初始化相机
        private async void InitCamera() {
            init_camera_btn.Enabled = false;
            initCameraMenu_item.Enabled = false;
            string errorMessage = null;

            Logger.Instance.AddLog("相机初始化中...");


            errorMessage = await _cameraControl.Initialize();

            if (errorMessage != null) {
                Logger.Instance.AddLog($@"相机连接错误：{errorMessage}", LogLevel.Error);
                init_camera_btn.Enabled = true;
                return;
            }

            indicatorLight1.IsOn = true;
            start_live.Enabled = true;
            first_pho.Enabled = true;
            second_pho.Enabled = true;
            disconnectCamera_item.Enabled = true;

            Logger.Instance.AddLog("相机初始化完成");

            // 绑定拍照完成事件
            _cameraControl.Acq.Complete += Complete;
        }

        // 加载toolblock vpp
        private async void LoadVppFile() {
            Logger.Instance.AddLog("正在尝试加载ToolBlock vpp...");

            if (!File.Exists(_toolBlockVppPath)) {
                MyToolBlock.Instance.SetToolBlock(new CogToolBlock());
                Logger.Instance.AddLog("未发现ToolBlock vpp文件，可以打开标定界面手动操作或选择一个外部vpp文件");
            }
            else {
                (string errorMsg, LogLevel logLevel) = await Task.Run(() => {
                    try {
                        var tb = CogSerializer.LoadObjectFromFile(_toolBlockVppPath) as CogToolBlock;
                        MyToolBlock.Instance.SetToolBlock(tb);

                        RunOnUIThread(() => {
                            MyToolBlock.Instance.ToolBlock.Ran += ToolBlockOnRan;
                            MyToolBlock.Instance.ToolBlock.Ran += PlcControlToolBlockOnRan;
                            calibrate_item.Enabled = true;
                        });
                        return ("发现vpp文件，加载成功", LogLevel.Info);
                    }
                    catch (Exception exception) {
                        return ($"加载ToolBlock文件发生未知错误：{exception.Message}", LogLevel.Error);
                    }
                });

                Logger.Instance.AddLog(errorMsg, logLevel);
            }
        }

        // 触发拍照的公共逻辑
        private void TriggerAcquisition(PhotoTriggerSource source) {
            first_pho.Enabled = false;
            second_pho.Enabled = false;
            _photoTriggerSource = source;

            var message = _cameraControl.TakePhotoGraph();
            Logger.Instance.AddLog(message);
        }

        // 恢复控件到UI线程执行
        private void RunOnUIThread(Action action) {
            if (InvokeRequired) {
                Invoke(action);
            }
            else {
                action();
            }
        }

        #endregion


        #region 事件

        // listview更新事件
        private void LogListOnListChanged(object sender, ListChangedEventArgs e) {
            var log = Logger.Instance.Logs.LastOrDefault();
            var item = new ListViewItem(log?.TimeStamp);

            RunOnUIThread(() => {
                item.SubItems.Add(log?.Level.ToString());
                item.SubItems.Add(log?.Message);
                listView1.Items.Add(item);
                listView1.Items[listView1.Items.Count - 1].EnsureVisible();
            });
        }

        #region 控制cogDisplay放大缩小

        // 初始化子控件控制
        private void InitializeChildControls() {
            RegisterControl(myDisplay1, panel5, "实时预览");
            RegisterControl(myDisplay2, panel6, "一次拍照");
            RegisterControl(myDisplay3, panel7, "二次拍照");
            RegisterControl(listView1, panel11);
            RegisterControl(tableLayoutPanel7, panel10);
        }

        // 注册子控件事件
        private void RegisterControl(Control control, Panel parent, string labelText = "") {
            var info = new ChildControlInfo(control, parent, control.Dock);
            _controlInfos.Add(control, info);

            if (control is MyDisplay display) {
                display.SetLabelText(labelText);
                display.MaximizeRestoreRequested += UserControl_MaximizeRestoreRequested;
            }
        }

        // 控制事件
        private void UserControl_MaximizeRestoreRequested(object sender, EventArgs e) {
            var requestedControl = sender as Control;
            if (requestedControl == null || !_controlInfos.TryGetValue(requestedControl, out var requestedInfo)) {
                return; // 无效的请求
            }


            if (_childControlInfo == null) {
                MaximizeControl(requestedInfo);
            }

            else if (_childControlInfo == requestedInfo) {
                RestoreControl(requestedInfo);
            }
        }

        // 最大化控制
        private void MaximizeControl(ChildControlInfo info) {
            if (info == null) return;

            _childControlInfo = info; // 记录哪个被最大化了
            // 状态
            info.Status = ChildControlStatus.Maximized;

            // 改变父控件（放大）
            info.ControlInstance.Parent = panel4;

            // 填满（放大）
            info.ControlInstance.Dock = DockStyle.Fill;

            info.ControlInstance.BringToFront();
        }

        // 还原控件的逻辑
        private void RestoreControl(ChildControlInfo info) {
            if (info == null) return;

            // 状态
            info.Status = ChildControlStatus.Minimized;

            // 清空
            _childControlInfo = null; // 清除最大化记录


            info.ControlInstance.Dock = info.OriginalDockStyle;

            // 改回原来的父控件
            info.ControlInstance.Parent = info.OriginalParent;
        }

        #endregion

        // 初始化相机事件
        private void init_camera_btn_Click(object sender, EventArgs e) {
            InitCamera();
        }


        // 事件：toolblock 执行运行后
        private void ToolBlockOnRan(object sender, EventArgs e) {
            cogRecordDisplay1.Invoke((MethodInvoker)delegate {
                cogRecordDisplay1.Record =
                    MyToolBlock.Instance.ToolBlock.CreateLastRunRecord().SubRecords["CogImageConvertTool1.OutputImage"];
            });

            // Logger.Instance.AddLog("图像处理完成，已加载到RecordDisplay");
            // "图像处理完成，已加载到RecordDisplay"

            MyToolBlock.Instance.RunCount++;
            if (MyToolBlock.Instance.GetPmaResult().Count > 0) {
                MyToolBlock.Instance.PassCount++;
            }
        }

        // 开启实时
        private void start_live_Click(object sender, EventArgs e) {
            myDisplay1.StartLive(_cameraControl.Acq);

            Logger.Instance.AddLog("开启相机实时预览");

            start_live.Enabled = false;
            stop_live.Enabled = true;
        }

        // 关闭实时
        private void stop_live_Click(object sender, EventArgs e) {
            myDisplay1.StopLive();

            Logger.Instance.AddLog("关闭相机实时预览");

            stop_live.Enabled = false;
            start_live.Enabled = true;
        }

        // 一次拍照
        private void first_pho_Click(object sender, EventArgs e) {
            Logger.Instance.AddLog("开始一次拍照...");
            TriggerAcquisition(PhotoTriggerSource.First);
        }

        // 二次拍照
        private void second_pho_Click(object sender, EventArgs e) {
            Logger.Instance.AddLog("开始二次拍照...");
            TriggerAcquisition(PhotoTriggerSource.Second);
        }

        // 拍照完成事件
        private void Complete(object sender, CogCompleteEventArgs e) {
            try {
                var image = _cameraControl.GetGraphic();
                if (_photoTriggerSource == PhotoTriggerSource.First) {
                    RunOnUIThread(() => { myDisplay2.SetGraphic(image); });
                }

                if (_photoTriggerSource == PhotoTriggerSource.Second) {
                    RunOnUIThread(() => { myDisplay3.SetGraphic(image); });
                }



                // 传图像给toolblock
                if (MyToolBlock.Instance.ToolBlock != null) {
                    if (!MyToolBlock.Instance.ToolBlock.Inputs.Contains("InputImage")) {
                        MyToolBlock.Instance.ToolBlock.Inputs.Add(new CogToolBlockTerminal("InputImage", image));
                    }

                    MyToolBlock.Instance.ToolBlock.Inputs["InputImage"].Value = image;

                    // Logger.Instance.AddLog("图像已加载到ToolBlock，开始处理图像...");
                    //图像已加载到ToolBlock，开始处理图像...
                    MyToolBlock.Instance.ToolBlock.Run();
                }
                else {
                    Logger.Instance.AddLog("ToolBlock vpp文件未加载，图像不会被处理");
                }

                _cameraControl.IsShooting = false;
                RunOnUIThread(() => {
                    first_pho.Enabled = true;
                    second_pho.Enabled = true;
                });
            }
            catch (Exception exception) {
                Logger.Instance.AddLog(exception.Message, LogLevel.Error);
            }
        }


        // 开启标定作业窗口
        private void calibrate_Click(object sender, EventArgs e) {
            Logger.Instance.AddLog("打开标定作业Form...");
            var calibrateForm = new Form2();
            calibrateForm.Show();
        }


        // 关闭窗口
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            // 关闭实时预览
            if (myDisplay1.LiveDisplayStatus()) {
                myDisplay1.StopLive();
            }

            // 销毁相机实例
            _cameraControl.DisposeCamera();
            // 断开plc
            PlcControl.Instance.Disconnect();

            Logger.Instance.Logs.ListChanged -= LogListOnListChanged;

            if (_cameraControl.Acq != null) {
                _cameraControl.Acq.Complete -= Complete;
            }

            if (MyToolBlock.Instance.ToolBlock != null) {
                MyToolBlock.Instance.ToolBlock.Ran -= ToolBlockOnRan;
            }
        }

        // recordDisplay窗口放大缩小
        private void label2_DoubleClick(object sender, EventArgs e) {
            UserControl_MaximizeRestoreRequested(tableLayoutPanel7, e);
        }

        // 导出日志CSV
        private async void exportCsv_Click(object sender, EventArgs e) {
            Logger.Instance.AddLog("正在导出日志...");

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"CSV文件 (*.csv)|*.csv";
            saveFileDialog.FileName = "Log.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                var message = await Logger.Instance.ExportToCsv(saveFileDialog.FileName);
                Logger.Instance.AddLog(message);
            }
            else {
                Logger.Instance.AddLog("取消导出日志");
            }
        }


        // 工具栏控制listview放大缩小按钮
        private void maxControl_Click(object sender, EventArgs e) {
            _controlInfos.TryGetValue(listView1, out var lv);

            if (lv?.Status == ChildControlStatus.Maximized) {
                maxControl.Text = @"放大";
            }
            else if (lv?.Status == ChildControlStatus.Minimized) {
                maxControl.Text = @"缩小";
            }

            UserControl_MaximizeRestoreRequested(listView1, e);
        }

        // 工具栏导出日志按钮事件
        private void exportLog_Click(object sender, EventArgs e) {
            exportCsv_Click(sender, e);
        }

        // 初始化相机事件
        private void initCamera_menuItem_Click(object sender, EventArgs e) {
            InitCamera();

            initCameraMenu_item.Enabled = false;
        }

        // 断开相机
        private void disconnectCamera_item_Click(object sender, EventArgs e) {
            // 断开相机
            _cameraControl.DisposeCamera();

            start_live.Enabled = false;
            stop_live.Enabled = false;
            first_pho.Enabled = false;
            second_pho.Enabled = false;
            disconnectCamera_item.Enabled = false;
            initCameraMenu_item.Enabled = true;
            init_camera_btn.Enabled = true;
            indicatorLight1.IsOn = false;
            Logger.Instance.AddLog("相机已断开...");
        }

        // 加载toolblock 按钮
        private void loadToolBlock_item_Click(object sender, EventArgs e) {
            LoadVppFile();

            loadToolBlock_item.Enabled = false;
        }

        // plc连接
        private async void connect_plc_Click(object sender, EventArgs e) {
            var message = await Task.Run(() => {
                try {
                    PlcControl.Instance.Connect();

                    if (PlcControl.Instance.IsConnected) {
                        PlcControl.Instance.PlcButtonPressed += OnPlcButtonPressed;
                        RunOnUIThread(() => {
                            connect_plc.Enabled = false;
                            disconnect_plc.Enabled = true;
                        });
                        return "PLC连接成功";
                    }

                    throw new Exception("PLC连接失败");
                }
                catch (Exception exception) {
                    return exception.Message;
                }
            });
            Logger.Instance.AddLog(message);
        }

        // PLC按钮被按下事件
        private void OnPlcButtonPressed(object sender, EventArgs e) {
            if (!_cameraControl.IsShooting) {
                RunOnUIThread(() => TriggerAcquisition(PhotoTriggerSource.First));
            }
        }

        // toolblock运行后plc执行
        private async void PlcControlToolBlockOnRan(object sender, EventArgs e) {
            // 获取toolblock结果，执行PLC
            try {
                var res = MyToolBlock.Instance.GetPmaResult();
                if (res.Count < 1) {
                    // Logger.Instance.AddLog("不良品");
                    // 不良品
                    await PlcControl.Instance.Write(PlcDataAddress.OnRed.GetAddress(),
                        1); //plc设备问题只有红灯会亮，Green 1 红灯灭，Green2红灯亮
                }
                else {
                    // Logger.Instance.AddLog("良品");
                    // 良品
                    await PlcControl.Instance.Write(PlcDataAddress.OnRed.GetAddress(), 0);
                }
            }
            catch (Exception exception) {
                Logger.Instance.AddLog($"PLC状态写入失败：{exception.Message}");
            }
        }

        // plc断开
        private void disconnect_plc_Click(object sender, EventArgs e) {
            PlcControl.Instance.PlcButtonPressed -= OnPlcButtonPressed;
            PlcControl.Instance.Disconnect();

            connect_plc.Enabled = true;
            disconnect_plc.Enabled = false;
            Logger.Instance.AddLog("PLC断开连接");
        }

        #endregion
    }
}