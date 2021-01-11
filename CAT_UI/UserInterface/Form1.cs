using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//using System.Threading;

namespace UserInterface
{
    public partial class CAT_UI : Form
    {
        //public variable declarations
        public bool rec;
        public delegate void SetTextDeleg(string text);
        public Form2 form2 = new Form2();
        public Form3 form3 = new Form3();
        public DateTime dateTime;
        public Series tempSens1 = new Series();
        public Series tempSens2 = new Series();
        public Series tempSens3 = new Series();
        public Series tempSens4 = new Series();
        public Series tempSens5 = new Series();
        public Series tempSens6 = new Series();
        public Series pressSens1 = new Series();
        public Series pressSens2 = new Series();
        public Series pressSens3 = new Series();
        public Series pressSens4 = new Series();
        public Series pressSens5 = new Series();
        public Series pressSens6 = new Series();
        public enum BoxType : int
        {
            Horizontal, Vertical, ThreewayF, ThreewayO
        }

        private void CAT_UI_Load(object sender, EventArgs e)
        {
            // Make the form full screen
            this.Bounds = Screen.PrimaryScreen.Bounds;

            // Show the connect COM port form
            form2.Show();
            form2.TopMost = true;

            // Check boxes set to true
            setCheckBoxTrue();

            // Initialise Temperature Data Series
            // Sensor 1
            tempSens1 = seriesInit(tempSens1, "TempSensor1");
            chartTemp.Series.Add(tempSens1);
            // Sensor 2
            tempSens2 = seriesInit(tempSens2, "TempSensor2");
            chartTemp.Series.Add(tempSens2);
            // Sensor 3
            tempSens3 = seriesInit(tempSens3, "TempSensor3");
            chartTemp.Series.Add(tempSens3);
            // Sensor 4
            tempSens4 = seriesInit(tempSens4, "TempSensor4");
            chartTemp.Series.Add(tempSens4);
            // Sensor 5
            tempSens5 = seriesInit(tempSens5, "TempSensor5");
            chartTemp.Series.Add(tempSens5);
            // Sensor 6
            tempSens6 = seriesInit(tempSens6, "TempSensor6");
            chartTemp.Series.Add(tempSens6);

            // Initialise Pressure Data Series
            // Sensor 1
            pressSens1 = seriesInit(pressSens1, "PressSensor1");
            chartPress.Series.Add(pressSens1);
            // Sensor 2
            pressSens2 = seriesInit(pressSens2, "PressSensor2");
            chartPress.Series.Add(pressSens2);
            // Sensor 3
            pressSens3 = seriesInit(pressSens3, "PressSensor3");
            chartPress.Series.Add(pressSens3);
            // Sensor 4
            pressSens4 = seriesInit(pressSens4, "PressSensor4");
            chartPress.Series.Add(pressSens4);
            // Sensor 5
            pressSens5 = seriesInit(pressSens5, "PressSensor5");
            chartPress.Series.Add(pressSens5);
            // Sensor 6
            pressSens6 = seriesInit(pressSens6, "PressSensor6");
            chartPress.Series.Add(pressSens6);

            // Initialise Temperature Chart
            Title title1 = chartTemp.Titles.Add("Temperature");
            chartTemp.ChartAreas["ChartArea1"].Visible = true;
            chartTemp.ChartAreas["ChartArea1"].AxisX.Name = "Time";
            chartTemp.ChartAreas["ChartArea1"].AxisY.Name = "Temperature";

            // Initialise Pressure Chart
            Title title2 = chartPress.Titles.Add("Pressure");
            chartPress.ChartAreas["ChartArea1"].Visible = true;
            chartPress.ChartAreas["ChartArea1"].AxisX.Name = "Time";
            chartPress.ChartAreas["ChartArea1"].AxisY.Name = "Pressure";
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
            rec = true;
            setCheckBoxTrue();
            ReconnectPort();
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            if (rec)
            {
                string x = sp.ReadLine();
                this.BeginInvoke(new SetTextDeleg(WriteData), new object[] { x });
            }
        }
        private void WriteSerialHandler(object sender, EventArgs e)
        {
            WriteSerial();
        }

        // Methods
        private void ReconnectPort()
        {
            clearSeries();
            dateTime = DateTime.Now;

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
                        if (checkBoxT1.Checked == true)
                        {
                            tbTemp1.Text = GetValue(datapnt);
                            addDataPnt(chartTemp, tempSens1, tbTemp1.Text);
                        }
                    }
                    else if (datapnt.Contains("T02"))
                    {
                        if (checkBoxT2.Checked == true)
                        {
                            tbTemp2.Text = GetValue(datapnt);
                            addDataPnt(chartTemp, tempSens2, tbTemp2.Text);
                        }
                    }
                    else if (datapnt.Contains("T03"))
                    {
                        if (checkBoxT3.Checked == true)
                        {
                            tbTemp3.Text = GetValue(datapnt);
                            addDataPnt(chartTemp, tempSens3, tbTemp3.Text);
                        }
                    }
                    else if (datapnt.Contains("T04"))
                    {
                        if (checkBoxT4.Checked == true)
                        {
                            tbTemp4.Text = GetValue(datapnt);
                            addDataPnt(chartTemp, tempSens4, tbTemp4.Text);
                        }
                    }
                    else if (datapnt.Contains("T05"))
                    {
                        if (checkBoxT5.Checked == true)
                        {
                            tbTemp5.Text = GetValue(datapnt);
                            addDataPnt(chartTemp, tempSens5, tbTemp5.Text);
                        }
                    }
                    else if (datapnt.Contains("T06"))
                    {
                        if (checkBoxT6.Checked == true)
                        {
                            tbTemp6.Text = GetValue(datapnt);
                            addDataPnt(chartTemp, tempSens6, tbTemp6.Text);
                        }
                    }
                    else if (datapnt.Contains("P01"))
                    {
                        if (checkBoxP1.Checked == true)
                        {
                            tbPress1.Text = GetValue(datapnt);
                            addDataPnt(chartPress, pressSens1, tbPress1.Text);
                        }
                    }
                    else if (datapnt.Contains("P02"))
                    {
                        if (checkBoxP2.Checked == true)
                        {
                            tbPress2.Text = GetValue(datapnt);
                            addDataPnt(chartPress, pressSens2, tbPress2.Text);
                        }
                    }
                    else if (datapnt.Contains("P03"))
                    {
                        if (checkBoxP3.Checked == true)
                        {
                            tbPress3.Text = GetValue(datapnt);
                            addDataPnt(chartPress, pressSens3, tbPress3.Text);
                        }
                    }
                    else if (datapnt.Contains("P04"))
                    {
                        if (checkBoxP4.Checked == true)
                        {
                            tbPress4.Text = GetValue(datapnt);
                            addDataPnt(chartPress, pressSens4, tbPress4.Text);
                        }
                    }
                    else if (datapnt.Contains("P05"))
                    {
                        if (checkBoxP5.Checked == true)
                        {
                            tbPress5.Text = GetValue(datapnt);
                            addDataPnt(chartPress, pressSens5, tbPress5.Text);
                        }
                    }
                    else if (datapnt.Contains("P06"))
                    {
                        if (checkBoxP6.Checked == true)
                        {
                            tbPress6.Text = GetValue(datapnt);
                            addDataPnt(chartPress, pressSens6, tbPress6.Text);
                        }
                    }
                    else if (datapnt.Contains("S01"))
                    {
                        tbFV1Pos.Text = GetValue(datapnt);
                        tbFV1State.Text = GetStateValue(datapnt);
                        drawServo(pbFV1, (int)BoxType.ThreewayF, GetValue(datapnt));
                    }
                    else if (datapnt.Contains("S02"))
                    {
                        tbFV2Pos.Text = GetValue(datapnt);
                        tbFV2State.Text = GetStateValue(datapnt);
                        drawServo(pbFV2, (int)BoxType.Horizontal, GetValue(datapnt));
                    }
                    else if (datapnt.Contains("S03"))
                    {
                        tbFV3Pos.Text = GetValue(datapnt);
                        tbFV3State.Text = GetStateValue(datapnt);
                        drawServo(pbFV3, (int)BoxType.Vertical, GetValue(datapnt));
                    }
                    else if (datapnt.Contains("S04"))
                    {
                        tbOV1Pos.Text = GetValue(datapnt);
                        tbOV1State.Text = GetStateValue(datapnt);
                        drawServo(pbOV1, (int)BoxType.ThreewayO, GetValue(datapnt));
                    }
                    else if (datapnt.Contains("S05"))
                    {
                        tbOV2Pos.Text = GetValue(datapnt);
                        tbOV2State.Text = GetStateValue(datapnt);
                        drawServo(pbOV2, (int)BoxType.Horizontal, GetValue(datapnt));
                    }
                    else if (datapnt.Contains("S06"))
                    {
                        tbOV3Pos.Text = GetValue(datapnt);
                        tbOV3State.Text = GetStateValue(datapnt);
                        drawServo(pbOV3, (int)BoxType.Vertical, GetValue(datapnt));
                    }
                    else if (datapnt.Contains("S07"))
                    {
                        tbNV1Pos.Text = GetValue(datapnt);
                        tbNV1State.Text = GetStateValue(datapnt);
                        drawServo(pbNV1, (int)BoxType.Horizontal, GetValue(datapnt));
                    }
                    else if (datapnt.Contains("S08"))
                    {
                        tbNV2Pos.Text = GetValue(datapnt);
                        tbNV2State.Text = GetStateValue(datapnt);
                        drawServo(pbNV2, (int)BoxType.Horizontal, GetValue(datapnt));
                    }
                    else if (datapnt.Contains("S09"))
                    {
                        tbPVPos.Text = GetValue(datapnt);
                        tbPVState.Text = GetStateValue(datapnt);
                        drawServo(pbPV, (int)BoxType.Vertical, GetValue(datapnt));
                    }
                    else if (datapnt.Contains("S10"))
                    {
                        tbFV4Pos.Text = GetValue(datapnt);
                        tbFV4State.Text = GetStateValue(datapnt);
                        drawServo(pbFV4, (int)BoxType.Vertical, GetValue(datapnt));
                    }
                    else if (datapnt.Contains("S11"))
                    {
                        tbOV4Pos.Text = GetValue(datapnt);
                        tbOV4State.Text = GetStateValue(datapnt);
                        drawServo(pbOV4, (int)BoxType.Vertical, GetValue(datapnt));
                    }
                }
            }
        }
        private void WriteSerial()
        {
            string valve = form3.ValveName;
            string position = form3.ValvePosition;
            if (!string.IsNullOrEmpty(position))
            {
                mySerialPort.WriteLine(valve + ":" + position);
            }
        }
        private void clearBoxes()
        {
            // Clear the boxes containing the temperature and pressure data
            tbTemp1.Text = "";
            tbTemp2.Text = "";
            tbTemp3.Text = "";
            tbTemp4.Text = "";
            tbTemp5.Text = "";
            tbTemp6.Text = "";
            tbPress1.Text = "";
            tbPress2.Text = "";
            tbPress3.Text = "";
            tbPress4.Text = "";
            tbPress5.Text = "";
            tbPress6.Text = "";
        }
        private void addDataPnt(Chart c, Series s, string datapnt)
        {
            double dataPnt = double.Parse(datapnt);
            TimeSpan dt = DateTime.Now - dateTime;
            double time = Math.Round(dt.TotalSeconds, 2);
            s.Points.AddXY(time, dataPnt);
            if (time < 5)
            {
                c.ChartAreas["ChartArea1"].AxisX.Minimum = 0;
            }
            else
            {
                c.ChartAreas["ChartArea1"].AxisX.Minimum = time - 5;
            }
        }
        private void setCheckBoxTrue()
        {
            checkBoxT1.Checked = true;
            checkBoxT2.Checked = true;
            checkBoxT3.Checked = true;
            checkBoxT4.Checked = true;
            checkBoxT5.Checked = true;
            checkBoxT6.Checked = true;
            checkBoxP1.Checked = true;
            checkBoxP2.Checked = true;
            checkBoxP3.Checked = true;
            checkBoxP4.Checked = true;
            checkBoxP5.Checked = true;
            checkBoxP6.Checked = true;
        }
        private void clearSeries()
        {
            foreach (var series in chartTemp.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chartPress.Series)
            {
                series.Points.Clear();
            }
        }
        private void drawServo(PictureBox pb, int boxType, string degrees)
        {
            int x = 2;
            int y = 2;
            int width = 40;
            int height = 40;
            float deg = float.Parse(degrees);

            Graphics g = pb.CreateGraphics();
            g.Clear(Color.Transparent);

            Pen myPen = new Pen(Color.Black, 2f);
            SolidBrush myBrush = new SolidBrush(Color.White);
            SolidBrush myBrush1 = new SolidBrush(Color.Black);

            g.FillRectangle(myBrush, x, y, width, height); 

            switch(boxType)
            {
                case (int)BoxType.Horizontal:
                    g.TranslateTransform((width + 2) / 2, (height + 2) / 2);
                    g.RotateTransform(deg);
                    g.TranslateTransform(-(width + 2) / 2, -(height + 2) / 2);
                    g.DrawRectangle(myPen, x + 2, y + 15, width - 4, 8);
                    g.FillRectangle(myBrush1, x + 2, y + 15, width - 4, 8);
                    break;
                case (int)BoxType.Vertical:
                    g.TranslateTransform((width + 6) / 2, (height + 3) / 2);
                    g.RotateTransform(deg);
                    g.TranslateTransform(-(width + 6) / 2, -(height + 3) / 2);
                    g.DrawRectangle(myPen, x + 15, y + 2, 8, height - 4);
                    g.FillRectangle(myBrush1, x + 15, y + 2, 8, height - 4);
                    break;
                case (int)BoxType.ThreewayF:
                    g.TranslateTransform((width + 6) / 2, (height + 3) / 2);
                    g.RotateTransform(-deg);
                    g.TranslateTransform(-(width + 6) / 2, -(height + 3) / 2);
                    g.DrawRectangle(myPen, x + 15, y + 2, 8, height - 4);
                    g.FillRectangle(myBrush1, x + 15, y + 2, 8, height - 4);
                    g.DrawRectangle(myPen, x + 2, y + 15, (width - 4) / 2, 8);
                    g.FillRectangle(myBrush1, x + 2, y + 15, (width - 4) / 2, 8);
                    break;
                case (int)BoxType.ThreewayO:
                    g.TranslateTransform((width + 6) / 2, (height + 3) / 2);
                    g.RotateTransform(deg);
                    g.TranslateTransform(-(width + 6) / 2, -(height + 3) / 2);
                    g.DrawRectangle(myPen, x + 15, y + 2, 8, height - 4);
                    g.FillRectangle(myBrush1, x + 15, y + 2, 8, height - 4);
                    g.DrawRectangle(myPen, x + 15, y + 15, (width - 4) / 2, 8);
                    g.FillRectangle(myBrush1, x + 15, y + 15, (width - 4) / 2, 8);
                    break;
            }
        }
        private string GetValue(string line)
        {
            string[] data = line.Split(':');
            return data[1];
        }
        private string GetStateValue(string line)
        {
            string state = " ";
            string[] data = new string[3];
            data = line.Split(':');
            try
            {
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
                    return state;
                }
            }
            catch (Exception)
            {
                return state;
            }
        }
        private Series seriesInit(Series s, string name)
        {
            s.Name = name;
            s.ChartType = SeriesChartType.Line;
            s.BorderWidth = 3;
            return s;
        }
        

        // Button Events
        private void btnReConnect_Click(object sender, EventArgs e)
        {
            mySerialPort.Close();
            clearBoxes();
            form2.Show();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.White;
            btnStop.BackColor = Color.Red;
            mySerialPort.WriteLine("Start");
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.BackColor = Color.White;
            btnStart.BackColor = Color.Green;
            mySerialPort.WriteLine("Stop");
            clearBoxes();
        }
        private void btnActuate_Click(object sender, EventArgs e)
        {
            form3.Show();
            form3.TopMost = true;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            mySerialPort.WriteLine("Reset");
        }
        private void btnStopRec_Click(object sender, EventArgs e)
        {
            rec = false;
            clearBoxes();
            mySerialPort.WriteLine("StopRec");
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearBoxes();
            clearSeries();
        }
    }
}