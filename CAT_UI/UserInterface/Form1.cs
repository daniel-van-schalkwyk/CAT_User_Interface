using System;
using System.IO.Ports;
using System.Threading;
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
        public SerialPort myport = new SerialPort("COM11", 115200);
        private delegate void SetTextDeleg(string text);
        string dataReceived;

        public CAT_UI()
        {
            InitializeComponent();
            myport.DtrEnable = true;
            myport.Open();
            myport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string x = sp.ReadLine();
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { x });

        }

        private void si_DataReceived(string data)
        {
            dataReceived = data.Trim();
            //tbTemp1.Text = dataReceived;
            ReceiveData(dataReceived);
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            ReceiveData(dataReceived);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbTemp1.Text = "";
            tbTemp2.Text = "";
            tbPress1.Text = "";
            tbPress2.Text = "";
            tbPress3.Text = "";
            tbPress4.Text = "";
            tbPress5.Text = "";
            tbPress6.Text = "";
        }

        private string GetValue(string line)
        {
            string[] data = line.Split(':');
            return data[1];
        }

        private void ReceiveData(string indata)
        {
            if (indata != null)
            {
                string[] splitdata = indata.Split(',');
                foreach (string datapnt in splitdata)
                {
                    if (datapnt.Contains("T01"))
                    {
                        tbTemp1.Text = GetValue(datapnt);
                        //tbTemp1.Text = datapnt;
                    }
                    else if (datapnt.Contains("T02"))
                    {
                        tbTemp2.Text = GetValue(datapnt);
                        //tbTemp2.Text = datapnt;
                    }
                    else if (datapnt.Contains("P01"))
                    {
                        tbPress1.Text = GetValue(datapnt);
                        //tbPress1.Text = datapnt;
                    }
                    else if (datapnt.Contains("P02"))
                    {
                        tbPress2.Text = GetValue(datapnt);
                        //tbPress2.Text = datapnt;
                    }
                    else if (datapnt.Contains("P03"))
                    {
                        tbPress3.Text = GetValue(datapnt);
                        //tbPress3.Text = datapnt;
                    }
                    else if (datapnt.Contains("P04"))
                    {
                        tbPress4.Text = GetValue(datapnt);
                        //tbPress4.Text = datapnt;
                    }
                    else if (datapnt.Contains("P05"))
                    {
                        tbPress5.Text = GetValue(datapnt);
                        //tbPress5.Text = datapnt;
                    }
                    else if (datapnt.Contains("P06"))
                    {
                        tbPress6.Text = GetValue(datapnt);
                        //tbPress6.Text = datapnt;
                    }
                }
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string sentence = myport.ReadLine();
            if (sentence != null)
            {
                tbTemp1.Text = "Yay!";
            }
            else
            {
                tbTemp1.Text = "Boo!";
            }
        }
    }
}
