using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestExecutor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SapiX.Api.Execute(richTextBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SapiX.Api.Inject();
        }
    }
}
