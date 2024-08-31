using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体应用的尝试 {
	public partial class Form1 : Form {
		public Form1 () {
			InitializeComponent();
		}
		int count = 0;

		private void button1_Click ( object sender , EventArgs e ) {
			count++;
			//消息弹窗
			MessageBox.Show(count.ToString());
		}

		private void button1_MouseCaptureChanged ( object sender , EventArgs e ) {

		}
	}
}
