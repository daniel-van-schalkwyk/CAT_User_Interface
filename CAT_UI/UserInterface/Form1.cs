using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class CAT_UI : Form
    {
        public SerialPort myport;
        private delegate void SetTextDeleg(string text);
        private readonly string COMPort;
        readonly int BaudRate;
        public Form newForm = new Form2();

        private void CAT_UI_Load(object sender, EventArgs e)
        {
            newForm.Show();
            newForm.TopMost = true;
        }

        public CAT_UI()
        {
            InitializeComponent();

            COMPort = Form2.COMPort;
            BaudRate = Form2.BaudRate;

            if (COMPort != null && BaudRate != 0)
            {
                myport = new SerialPort(COMPort, BaudRate);
                myport.DtrEnable = true;
                try
                {
                    myport.Open();
                }
                catch
                {
                    MessageBox.Show("Port not accessible. Try again.");
                    newForm.Show();
                }
                myport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
        }
        
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string x = sp.ReadLine();
            this.BeginInvoke(new SetTextDeleg(ReceiveData), new object[] { x });

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
                    }
                    else if (datapnt.Contains("T02"))
                    {
                        tbTemp2.Text = GetValue(datapnt);
                    }
                    else if (datapnt.Contains("P01"))
                    {
                        tbPress1.Text = GetValue(datapnt);
                    }
                    else if (datapnt.Contains("P02"))
                    {
                        tbPress2.Text = GetValue(datapnt);
                    }
                    else if (datapnt.Contains("P03"))
                    {
                        tbPress3.Text = GetValue(datapnt);
                    }
                    else if (datapnt.Contains("P04"))
                    {
                        tbPress4.Text = GetValue(datapnt);
                    }
                    else if (datapnt.Contains("P05"))
                    {
                        tbPress5.Text = GetValue(datapnt);
                    }
                    else if (datapnt.Contains("P06"))
                    {
                        tbPress6.Text = GetValue(datapnt);
                    }
                    else if (datapnt.Contains("S01"))
                    {
                        tbFV1Pos.Text = GetValue(datapnt);
                    }
                }
            }
        }

        private void btnReConnect_Click(object sender, EventArgs e)
        {
            newForm.Show();
        }
    }
}
