using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Cognex.VisionPro;

namespace WindowsFormsApp1.Views {
    public partial class MyDisplay : UserControl {
        // 事件
        public event EventHandler MaximizeRestoreRequested;

        public MyDisplay() {
            InitializeComponent();
        }

        public void StartLive(object acqFifo, [Optional] bool own) {
            cogDisplay1.StartLiveDisplay(acqFifo);
            cogDisplay1.AutoFit = true;
        }

        public void StopLive() {
            cogDisplay1.StopLiveDisplay();

            cogDisplay1.Image = null;
        }

        public ICogImage GetDisplayImage() {
            return cogDisplay1.Image;
        }

        public void SetGraphic(ICogImage image) {
            cogDisplay1.Image = image;
            cogDisplay1.AutoFit = true;
        }

        public bool LiveDisplayStatus() {
            return cogDisplay1.LiveDisplayRunning;
        }


        public void SetLabelText(string text) {
            label1.Text = text;
        }

        private void label1_DoubleClick(object sender, EventArgs e) {
            MaximizeRestoreRequested?.Invoke(this, EventArgs.Empty);
        }
    }
}