using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassLibrary1.Class1 test = new ClassLibrary1.Class1();
            test.Main();
            var logData = test.logData;
            var logData1 = test.logData1;
            richTextBox1.Text = logData1 + logData;
        }
    }
}
