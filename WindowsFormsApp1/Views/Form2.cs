﻿using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using WindowsFormsApp1.Common;
using WindowsFormsApp1.Enum;

namespace WindowsFormsApp1.Views {
    public partial class Form2 : Form {
        private readonly string _vppPath = Path.Combine(Application.StartupPath, "vpp/ToolBlock.vpp");


        public Form2() {
            InitializeComponent();

            cogToolBlockEditV21.Subject = MyToolBlock.Instance.ToolBlock;
        }

        // 保存文件
        private async void saveFile_item_Click(object sender, EventArgs e) {
            DialogResult dialogResult;
            if (MyToolBlock.Instance.ToolBlock.Inputs.Count == 0 && MyToolBlock.Instance.ToolBlock.Outputs.Count == 0 &&
                MyToolBlock.Instance.ToolBlock.Tools.Count == 0) {
                dialogResult = MessageBox.Show(@"文件还没有修改过，确定保存吗？", @"保存提示", MessageBoxButtons.OKCancel);
            }
            else {
                dialogResult = MessageBox.Show(@"文件有修改痕迹，确定保存吗？", @"保存提示", MessageBoxButtons.OKCancel);
            }

            switch (dialogResult) {
                case DialogResult.OK:
                    var (msg, logLevel) = await Task.Run(() => {
                        try {
                            if (!File.Exists(_vppPath)) {
                                Directory.CreateDirectory("./vpp/");
                            }

                            CogSerializer.SaveObjectToFile(MyToolBlock.Instance.ToolBlock, _vppPath,
                                typeof(BinaryFormatter),
                                CogSerializationOptionsConstants.Minimum);
                            return ("保存成功", LogLevel.Info);
                        }
                        catch (Exception exception) {
                            return ($"保存失败：{exception.Message}", LogLevel.Error);
                        }
                    });
                    Logger.Instance.AddLog(msg, logLevel);
                    return;
                case DialogResult.Cancel:
                    Logger.Instance.AddLog("取消保存");
                    return;
            }
        }

        private void PMA_item_Click(object sender, EventArgs e) {
            var pmaResultsFrom = new Form3();
            pmaResultsFrom.Show();
        }
    }
}