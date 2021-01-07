using System;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class CAT_UI : Form
    {
        //public variable declarations
        public delegate void SetTextDeleg(string text);
        public Form2 newForm = new Form2();

        private void CAT_UI_Load(object sender, EventArgs e)
        {
            newForm.Show();
            newForm.TopMost = true;
        }

        public CAT_UI()
        {
            InitializeComponent();

            newForm.btnConnect.Click += new EventHandler(ReconnectPortHandler);
        }

        // Event Handlers
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string x = sp.ReadLine();
            this.BeginInvoke(new SetTextDeleg(ReceiveData), new object[] { x });
        }
        private void ReconnectPortHandler(object sender, EventArgs e)
        {
            ReconnectPort();
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            //tbTemp1.Text = "The event click is working!:)";
        }

        // Methods
        public void ReconnectPort()
        {
            string CP = newForm.COMPort;
            int BR = newForm.BaudRate;

            mySerialPort = new SerialPort(CP, BR);
            mySerialPort.DtrEnable = true;
            try
            {
                mySerialPort.Open();
            }
            catch
            {
                MessageBox.Show("Port not accessible. Try again.");
                newForm.Show();
            }
        }
        private string GetValue(string line)
        {
            string[] data = line.Split(':');
            return data[1];
        }
        public string GetStateValue(string line)
        {
            string[] data = line.Split(':');
            return data[2];
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
                        //tbFV1State.Text = GetStateValue(datapnt);
                    }
                    else if (datapnt.Contains("S02"))
                    {
                        tbFV2Pos.Text = GetValue(datapnt);
                        //tbFV2State.Text = GetStateValue(datapnt);
                    }
                    else if (datapnt.Contains("S03"))
                    {
                        tbFV3Pos.Text = GetValue(datapnt);
                        //tbFV3State.Text = GetStateValue(datapnt);
                    }
                    else if (datapnt.Contains("S04"))
                    {
                        tbOV1Pos.Text = GetValue(datapnt);
                        //tbOV1State.Text = GetStateValue(datapnt);
                    }
                    else if (datapnt.Contains("S05"))
                    {
                        tbOV2Pos.Text = GetValue(datapnt);
                        //tbOV2State.Text = GetStateValue(datapnt);
                    }
                    else if (datapnt.Contains("S06"))
                    {
                        tbOV3Pos.Text = GetValue(datapnt);
                        //tbOV3State.Text = GetStateValue(datapnt);
                    }
                    else if (datapnt.Contains("S07"))
                    {
                        tbNV1Pos.Text = GetValue(datapnt);
                        //tbNV1State.Text = GetStateValue(datapnt);
                    }
                    else if (datapnt.Contains("S08"))
                    {
                        tbNV2Pos.Text = GetValue(datapnt);
                        //tbNV2State.Text = GetStateValue(datapnt);
                    }
                    else if (datapnt.Contains("S09"))
                    {
                        tbPVPos.Text = GetValue(datapnt);
                        //tbPVState.Text = GetStateValue(datapnt);
                    }
                }
            }
        }

        // Button Events
        private void btnReConnect_Click(object sender, EventArgs e)
        {
            mySerialPort.Close();
            ClearBoxes();
            newForm.Show();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
        private void ClearBoxes()
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
    }
}
