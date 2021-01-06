using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace CAT_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void btnGetPortNames_Click(object sender, EventArgs e)
        {
            string[] ArrayComPortNames;
            int index = -1;
            string ComPortName = null;

            ArrayComPortNames = SerialPort.GetPortNames();
            do
            {
                index += 1;
                richTextBox1.Text = ArrayComPortNames[index] + "\n";
            }
            while (!((ArrayComPortNames[index] == ComPortName) || (index == ArrayComPortNames.GetUpperBound(0))));
        }
    }
}
