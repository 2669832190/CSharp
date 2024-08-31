using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.窗体应用尝试
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //定义一个变量表示点击的次数
        int a = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            /*a = a + 1;
            //消息弹框
            //MessageBox.Show(a.ToString());
            label1.Text = $"{a}";*/
            Anniu(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*a = a + 10;
            //消息弹框
            //MessageBox.Show(a.ToString());
            label1.Text = $"{a}";*/
            Anniu(10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*a = a + 20;
            //消息弹框
            //MessageBox.Show(a.ToString());
            label1.Text = $"{a}";*/
            Anniu(20);
        }

        void Anniu(int x)
        {
            a = a + x;
            label1.Text = $"{a}";
            if(a>100)
            {
                label1.Text = $"功德无量！";
            }
            else
            {
                label1.Text = $"{a}";
            }
        }
    }
}
