using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 窗体应用实践 {
	public partial class Form1 : Form {
		public Form1 () {
			InitializeComponent();
		}
		int count = 0;

		private void label1_Click ( object sender , EventArgs e ) {

		}
		private void button1_Click ( object sender , EventArgs e ) {
			count++;
			label1.Text = "按钮点击了"+count+"次";
		}
	}
}
