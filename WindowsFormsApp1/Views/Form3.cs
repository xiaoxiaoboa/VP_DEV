using System;
using System.Globalization;
using System.Windows.Forms;
using WindowsFormsApp1.Common;

namespace WindowsFormsApp1.Views {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e) {
            var count = 1;
            var myPmaResults = MyToolBlock.Instance.GetPmaResult();

            var runCount = MyToolBlock.Instance.RunCount;
            var passCount = MyToolBlock.Instance.PassCount;
            
            // 总数量
            label2.Text = runCount.ToString();
            // 合格量
            label4.Text = passCount.ToString();
            // 合格率
            label6.Text = ((double)passCount / runCount).ToString("P2");
            // 不合格率量
            label8.Text = (runCount - passCount).ToString();

            listView1.Columns.Add("");
            listView1.Columns.Add("分数");
            listView1.Columns.Add("X");
            listView1.Columns.Add("Y");

            foreach (var pmaResult in myPmaResults) {
                var item = new ListViewItem(count.ToString());
                item.SubItems.Add(pmaResult.Score.ToString(CultureInfo.CurrentCulture));
                item.SubItems.Add(pmaResult.X.ToString(CultureInfo.CurrentCulture));
                item.SubItems.Add(pmaResult.Y.ToString(CultureInfo.CurrentCulture));
                listView1.Items.Add(item);
                count++;
            }
        }
    }
}