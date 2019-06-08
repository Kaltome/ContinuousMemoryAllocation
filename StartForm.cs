using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContinuousMemoryAllocation
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) MessageBox.Show("数据未填写", "提示");
            else if (int.TryParse(textBox1.Text, out int size) && size >= 400 && size <= 1600)
            {
                Hide();
                MainForm mainForm = new MainForm(size);
                mainForm.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("需要填入400~1600之间的数字", "提示");
                textBox1.Clear();
            }
        }
    }
}
