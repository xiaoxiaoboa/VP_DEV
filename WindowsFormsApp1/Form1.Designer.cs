using WindowsFormsApp1.Views;

namespace WindowsFormsApp1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.start_live = new System.Windows.Forms.Button();
            this.stop_live = new System.Windows.Forms.Button();
            this.first_pho = new System.Windows.Forms.Button();
            this.second_pho = new System.Windows.Forms.Button();
            this.connect_plc = new System.Windows.Forms.Button();
            this.disconnect_plc = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.init_camera_btn = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.indicatorLight1 = new WindowsFormsApp1.IndicatorLight();
            this.panel11 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.maxControl = new System.Windows.Forms.ToolStripMenuItem();
            this.exportCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.myDisplay1 = new WindowsFormsApp1.Views.MyDisplay();
            this.panel6 = new System.Windows.Forms.Panel();
            this.myDisplay2 = new WindowsFormsApp1.Views.MyDisplay();
            this.panel7 = new System.Windows.Forms.Panel();
            this.myDisplay3 = new WindowsFormsApp1.Views.MyDisplay();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.camera = new System.Windows.Forms.ToolStripMenuItem();
            this.initCameraMenu_item = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectCamera_item = new System.Windows.Forms.ToolStripMenuItem();
            this.vppCalibrate = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolBlock_item = new System.Windows.Forms.ToolStripMenuItem();
            this.calibrate_item = new System.Windows.Forms.ToolStripMenuItem();
            this.runlog = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLog_item = new System.Windows.Forms.ToolStripMenuItem();
            this.commu = new System.Windows.Forms.ToolStripMenuItem();
            this.operation = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.miniToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.miniToolStrip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 686);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1251, 657);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel11, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(369, 651);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(363, 319);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.tableLayoutPanel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 262);
            this.panel3.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.start_live, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.stop_live, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.first_pho, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.second_pho, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.connect_plc, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.disconnect_plc, 1, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(30);
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(357, 262);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // start_live
            // 
            this.start_live.Dock = System.Windows.Forms.DockStyle.Fill;
            this.start_live.Enabled = false;
            this.start_live.Location = new System.Drawing.Point(45, 45);
            this.start_live.Margin = new System.Windows.Forms.Padding(15);
            this.start_live.Name = "start_live";
            this.start_live.Size = new System.Drawing.Size(118, 37);
            this.start_live.TabIndex = 0;
            this.start_live.Text = "开启实时";
            this.start_live.UseVisualStyleBackColor = true;
            this.start_live.Click += new System.EventHandler(this.start_live_Click);
            // 
            // stop_live
            // 
            this.stop_live.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stop_live.Enabled = false;
            this.stop_live.Location = new System.Drawing.Point(193, 45);
            this.stop_live.Margin = new System.Windows.Forms.Padding(15);
            this.stop_live.Name = "stop_live";
            this.stop_live.Size = new System.Drawing.Size(119, 37);
            this.stop_live.TabIndex = 1;
            this.stop_live.Text = "停止实时";
            this.stop_live.UseVisualStyleBackColor = true;
            this.stop_live.Click += new System.EventHandler(this.stop_live_Click);
            // 
            // first_pho
            // 
            this.first_pho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.first_pho.Enabled = false;
            this.first_pho.Location = new System.Drawing.Point(45, 112);
            this.first_pho.Margin = new System.Windows.Forms.Padding(15);
            this.first_pho.Name = "first_pho";
            this.first_pho.Size = new System.Drawing.Size(118, 37);
            this.first_pho.TabIndex = 2;
            this.first_pho.Text = "第一次拍照";
            this.first_pho.UseVisualStyleBackColor = true;
            this.first_pho.Click += new System.EventHandler(this.first_pho_Click);
            // 
            // second_pho
            // 
            this.second_pho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.second_pho.Enabled = false;
            this.second_pho.Location = new System.Drawing.Point(193, 112);
            this.second_pho.Margin = new System.Windows.Forms.Padding(15);
            this.second_pho.Name = "second_pho";
            this.second_pho.Size = new System.Drawing.Size(119, 37);
            this.second_pho.TabIndex = 3;
            this.second_pho.Text = "第二次拍照";
            this.second_pho.UseVisualStyleBackColor = true;
            this.second_pho.Click += new System.EventHandler(this.second_pho_Click);
            // 
            // connect_plc
            // 
            this.connect_plc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.connect_plc.Location = new System.Drawing.Point(45, 179);
            this.connect_plc.Margin = new System.Windows.Forms.Padding(15);
            this.connect_plc.Name = "connect_plc";
            this.connect_plc.Size = new System.Drawing.Size(118, 38);
            this.connect_plc.TabIndex = 4;
            this.connect_plc.Text = "连接PLC";
            this.connect_plc.UseVisualStyleBackColor = true;
            this.connect_plc.Click += new System.EventHandler(this.connect_plc_Click);
            // 
            // disconnect_plc
            // 
            this.disconnect_plc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disconnect_plc.Enabled = false;
            this.disconnect_plc.Location = new System.Drawing.Point(193, 179);
            this.disconnect_plc.Margin = new System.Windows.Forms.Padding(15);
            this.disconnect_plc.Name = "disconnect_plc";
            this.disconnect_plc.Size = new System.Drawing.Size(119, 38);
            this.disconnect_plc.TabIndex = 5;
            this.disconnect_plc.Text = "断开连接";
            this.disconnect_plc.UseVisualStyleBackColor = true;
            this.disconnect_plc.Click += new System.EventHandler(this.disconnect_plc_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel8, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(357, 45);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 39);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label1.Size = new System.Drawing.Size(154, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "相机状态：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.Controls.Add(this.init_camera_btn);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(198, 3);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10, 0, 40, 0);
            this.panel8.Size = new System.Drawing.Size(156, 39);
            this.panel8.TabIndex = 1;
            // 
            // init_camera_btn
            // 
            this.init_camera_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.init_camera_btn.Location = new System.Drawing.Point(10, 0);
            this.init_camera_btn.Name = "init_camera_btn";
            this.init_camera_btn.Size = new System.Drawing.Size(106, 39);
            this.init_camera_btn.TabIndex = 0;
            this.init_camera_btn.Text = "初始化相机";
            this.init_camera_btn.UseVisualStyleBackColor = true;
            this.init_camera_btn.Click += new System.EventHandler(this.init_camera_btn_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.Controls.Add(this.indicatorLight1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(163, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5);
            this.panel9.Size = new System.Drawing.Size(29, 39);
            this.panel9.TabIndex = 2;
            // 
            // indicatorLight1
            // 
            this.indicatorLight1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.indicatorLight1.IsOn = false;
            this.indicatorLight1.Location = new System.Drawing.Point(5, 5);
            this.indicatorLight1.Name = "indicatorLight1";
            this.indicatorLight1.OffColor = System.Drawing.Color.Gray;
            this.indicatorLight1.OnColor = System.Drawing.Color.LimeGreen;
            this.indicatorLight1.Size = new System.Drawing.Size(19, 29);
            this.indicatorLight1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.Control;
            this.panel11.Controls.Add(this.listView1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(3, 328);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(363, 320);
            this.panel11.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.listView1.CausesValidation = false;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(363, 320);
            this.listView1.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listView1, "双击放大/缩小");
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.maxControl, this.exportCsv });
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 52);
            // 
            // maxControl
            // 
            this.maxControl.Name = "maxControl";
            this.maxControl.Size = new System.Drawing.Size(137, 24);
            this.maxControl.Text = "放大";
            this.maxControl.Click += new System.EventHandler(this.maxControl_Click);
            // 
            // exportCsv
            // 
            this.exportCsv.Name = "exportCsv";
            this.exportCsv.Size = new System.Drawing.Size(137, 24);
            this.exportCsv.Text = "导出CSV";
            this.exportCsv.Click += new System.EventHandler(this.exportCsv_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.tableLayoutPanel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(378, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(870, 651);
            this.panel4.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel7, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel10, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(870, 651);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.myDisplay1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(429, 319);
            this.panel5.TabIndex = 0;
            // 
            // myDisplay1
            // 
            this.myDisplay1.BackColor = System.Drawing.SystemColors.Control;
            this.myDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDisplay1.Location = new System.Drawing.Point(0, 0);
            this.myDisplay1.Name = "myDisplay1";
            this.myDisplay1.Size = new System.Drawing.Size(429, 319);
            this.myDisplay1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.myDisplay2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(438, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(429, 319);
            this.panel6.TabIndex = 1;
            // 
            // myDisplay2
            // 
            this.myDisplay2.BackColor = System.Drawing.SystemColors.Control;
            this.myDisplay2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDisplay2.Location = new System.Drawing.Point(0, 0);
            this.myDisplay2.Name = "myDisplay2";
            this.myDisplay2.Size = new System.Drawing.Size(429, 319);
            this.myDisplay2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.myDisplay3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 328);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(429, 320);
            this.panel7.TabIndex = 2;
            // 
            // myDisplay3
            // 
            this.myDisplay3.BackColor = System.Drawing.SystemColors.Control;
            this.myDisplay3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDisplay3.Location = new System.Drawing.Point(0, 0);
            this.myDisplay3.Name = "myDisplay3";
            this.myDisplay3.Size = new System.Drawing.Size(429, 320);
            this.myDisplay3.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.tableLayoutPanel7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(438, 328);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(429, 320);
            this.panel10.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.cogRecordDisplay1, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5625F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.4375F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5625F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.4375F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(429, 320);
            this.tableLayoutPanel7.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(423, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "RecordDisplay";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label2, "双击放大/缩小");
            this.label2.DoubleClick += new System.EventHandler(this.label2_DoubleClick);
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(3, 24);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(423, 293);
            this.cogRecordDisplay1.TabIndex = 1;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.camera, this.vppCalibrate, this.runlog, this.commu, this.operation });
            this.miniToolStrip.Location = new System.Drawing.Point(0, 0);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(1251, 29);
            this.miniToolStrip.TabIndex = 0;
            // 
            // camera
            // 
            this.camera.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.initCameraMenu_item, this.disconnectCamera_item });
            this.camera.Name = "camera";
            this.camera.Size = new System.Drawing.Size(51, 25);
            this.camera.Text = "相机";
            // 
            // initCameraMenu_item
            // 
            this.initCameraMenu_item.Name = "initCameraMenu_item";
            this.initCameraMenu_item.Size = new System.Drawing.Size(153, 24);
            this.initCameraMenu_item.Text = "初始化相机";
            this.initCameraMenu_item.Click += new System.EventHandler(this.initCamera_menuItem_Click);
            // 
            // disconnectCamera_item
            // 
            this.disconnectCamera_item.Enabled = false;
            this.disconnectCamera_item.Name = "disconnectCamera_item";
            this.disconnectCamera_item.Size = new System.Drawing.Size(153, 24);
            this.disconnectCamera_item.Text = "断开相机";
            this.disconnectCamera_item.Click += new System.EventHandler(this.disconnectCamera_item_Click);
            // 
            // vppCalibrate
            // 
            this.vppCalibrate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.loadToolBlock_item, this.calibrate_item });
            this.vppCalibrate.Name = "vppCalibrate";
            this.vppCalibrate.Size = new System.Drawing.Size(79, 25);
            this.vppCalibrate.Text = "vpp标定";
            // 
            // loadToolBlock_item
            // 
            this.loadToolBlock_item.Name = "loadToolBlock_item";
            this.loadToolBlock_item.Size = new System.Drawing.Size(124, 24);
            this.loadToolBlock_item.Text = "加载tb";
            this.loadToolBlock_item.Click += new System.EventHandler(this.loadToolBlock_item_Click);
            // 
            // calibrate_item
            // 
            this.calibrate_item.Name = "calibrate_item";
            this.calibrate_item.Size = new System.Drawing.Size(124, 24);
            this.calibrate_item.Text = "标定";
            this.calibrate_item.Click += new System.EventHandler(this.calibrate_Click);
            // 
            // runlog
            // 
            this.runlog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.exportLog_item });
            this.runlog.Name = "runlog";
            this.runlog.Size = new System.Drawing.Size(81, 25);
            this.runlog.Text = "运行日志";
            // 
            // exportLog_item
            // 
            this.exportLog_item.Name = "exportLog_item";
            this.exportLog_item.Size = new System.Drawing.Size(138, 24);
            this.exportLog_item.Text = "导出日志";
            this.exportLog_item.Click += new System.EventHandler(this.exportLog_Click);
            // 
            // commu
            // 
            this.commu.Name = "commu";
            this.commu.Size = new System.Drawing.Size(51, 25);
            this.commu.Text = "通信";
            // 
            // operation
            // 
            this.operation.Name = "operation";
            this.operation.Size = new System.Drawing.Size(51, 25);
            this.operation.Text = "操作";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1251, 686);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripMenuItem loadToolBlock_item;

        private System.Windows.Forms.ToolStripMenuItem disconnectCamera_item;

        private System.Windows.Forms.ToolStripMenuItem initCameraMenu_item;

        private System.Windows.Forms.ToolStripMenuItem exportLog_item;

        private System.Windows.Forms.ToolStripMenuItem maxControl;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportCsv;

        private System.Windows.Forms.ToolTip toolTip1;

        private System.Windows.Forms.ListView listView1;

        private System.Windows.Forms.Label label2;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;

        private WindowsFormsApp1.Views.MyDisplay myDisplay1;
        private WindowsFormsApp1.Views.MyDisplay myDisplay2;
        private WindowsFormsApp1.Views.MyDisplay myDisplay3;

        private System.Windows.Forms.Panel panel11;

        private System.Windows.Forms.ToolStripMenuItem calibrate_item;

        private System.Windows.Forms.ToolStripMenuItem operation;

        private System.Windows.Forms.ToolStripMenuItem commu;

        private System.Windows.Forms.ToolStripMenuItem runlog;

        private System.Windows.Forms.ToolStripMenuItem camera;
        private System.Windows.Forms.ToolStripMenuItem vppCalibrate;

        


        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel10;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

        private System.Windows.Forms.Panel panel4;

        private WindowsFormsApp1.IndicatorLight indicatorLight1;

        private System.Windows.Forms.Button init_camera_btn;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;

        private System.Windows.Forms.Button start_live;
        private System.Windows.Forms.Button stop_live;
        private System.Windows.Forms.Button first_pho;
        private System.Windows.Forms.Button second_pho;
        private System.Windows.Forms.Button connect_plc;
        private System.Windows.Forms.Button disconnect_plc;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

        private System.Windows.Forms.Panel panel3;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

        private System.Windows.Forms.MenuStrip miniToolStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}