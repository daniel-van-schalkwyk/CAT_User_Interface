using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class CAT_UI : Form
    {
        static SerialPort myport;

        public CAT_UI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myport = new SerialPort("COM11", 9600);
            myport.Open();
            string line = myport.ReadLine();
            tbTemp.Text = line;
            myport.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbTemp.Text = "";
        }
    }
}
