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
        public Form2 form2 = new Form2();
        public Form3 form3 = new Form3();

        private void CAT_UI_Load(object sender, EventArgs e)
        {
            form2.Show();
            form2.TopMost = true;
        }

        public CAT_UI()
        {
            InitializeComponent();

            form2.btnConnect.Click += new EventHandler(ReconnectPortHandler);
            form3.btnActuate.Click += new EventHandler(WriteSerialHandler);
        }

        // Event Handlers
        private void ReconnectPortHandler(object sender, EventArgs e)
        {
            ReconnectPort();
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string x = sp.ReadLine();
            this.BeginInvoke(new SetTextDeleg(WriteData), new object[] { x });
        }
        private void WriteSerialHandler(object sender, EventArgs e)
        {
            WriteSerial();
        }

        // Methods
        public void ReconnectPort()
        {
            string CP = form2.COMPort;
            int BR = form2.BaudRate;

            mySerialPort = new SerialPort(CP, BR);
            mySerialPort.DtrEnable = true;
            mySerialPort.Handshake = Handshake.None;
            try
            {
                mySerialPort.Open();
            }
            catch
            {
                MessageBox.Show("Port not accessible. Try again.");
                form2.Show();
            }
        }
        private void WriteData(string indata)
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
        private void WriteSerial()
        {
            string valve = form3.ValveName;
            string position = form3.ValvePosition;
            mySerialPort.WriteLine(valve + ":" + position);
            //tbFV1State.Text = valve + ":" + position;
        }
        private string GetValue(string line)
        {
            string[] data = line.Split(':');
            return data[1];
        }
        private string GetStateValue(string line)
        {
            string state;
            string[] data = line.Split(':');
            if (data[2].Contains("C"))
            {
                state = "Closed";
                return state;
            }
            else if (data[2].Contains("O"))
            {
                state = "Open";
                return state;
            }
            else if (data[2].Contains("I"))
            {
                state = "Isolate";
                return state;
            }
            else if (data[2].Contains("V"))
            {
                state = "Vent";
                return state;
            }
            else if (data[2].Contains("F"))
            {
                state = "Feed";
                return state;
            }
            else
            {
                state = " ";
                return state;
            }
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

        // Button Events
        private void btnReConnect_Click(object sender, EventArgs e)
        {
            mySerialPort.Close();
            ClearBoxes();
            form2.Show();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }
        private void btnActuate_Click(object sender, EventArgs e)
        {
            form3.Show();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            mySerialPort.WriteLine("Reset");
        }
    }
}
