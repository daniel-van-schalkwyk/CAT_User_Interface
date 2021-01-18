using System;
//using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UserInterface
{
    public partial class CAT_UI : Form
    {
        //public variable declarations
        public bool rec;
        public bool Trec;
        public bool Prec;
        public bool mouseUp = true;
        public bool setTime;
        public int count;
        public delegate void SetTextDeleg(string text);
        public Form2 form2 = new Form2();
        public DateTime dateTime;
        public DateTime fileTime;
        public Bitmap drawArea;
        public FileInfo file;
        public StringBuilder dataStream = new StringBuilder();
        public readonly string separator = ",";
        public readonly string headings = "TimeStamp,PressSens1,PressSens2,PressSens3,PressSens4,PressSens5,PressSens6,TempSens1,TempSens2,TempSens3,TempSens4,TempSens5,TempSens6,FV1,FV2,FV3,OV1,OV2,OV3,NV1,NV2,PV,FV4,OV4";


        // series declarations
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

        // Enum declarations
        public enum BoxType : int
        {
            Horizontal, Vertical, Threeway
        }
        public enum Servo : int
        {
            FV1, FV2, FV3, FV4, OV1, OV2, OV3, OV4, PV, NV1, NV2
        }

        // Form methods
        private void CAT_UI_Load(object sender, EventArgs e)
        {
            // Make the form full screen
            this.WindowState = FormWindowState.Maximized;

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

            // Initialise Pressure Chart
            Title title2 = chartPress.Titles.Add("Pressure");
            chartPress.ChartAreas["ChartArea1"].Visible = true;
        }
        public CAT_UI()
        {
            InitializeComponent();

            form2.btnConnect.Click += new EventHandler(ReconnectPortHandler);
        }

        // Event Handlers
        private void ReconnectPortHandler(object sender, EventArgs e)
        {
            Trec = true;
            Prec = true;
            setCheckBoxTrue();
            ReconnectPort();
            setTime = true;
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            if (rec)
            {
                if (setTime)
                {
                    fileTime = DateTime.Now;
                    setTime = false;
                }
                string x = sp.ReadLine();
                this.BeginInvoke(new SetTextDeleg(WriteData), new object[] { x });
            }
        }

        // Methods
        private void ReconnectPort()
        {
            clearTSeries();
            clearPSeries();
            dateTime = DateTime.Now;

            string CP = form2.COMPort;
            int BR = form2.BaudRate;
            mySerialPort = new SerialPort(CP, BR);
            mySerialPort.DtrEnable = true;
            mySerialPort.Handshake = Handshake.None;
            try
            {
                mySerialPort.Open();
                DateTime fileDate = DateTime.Now;
                string filename = fileDate.ToString("dd-MM-yy") + "_" + fileDate.ToString("HH-mm");
                string path = "C:\\Users\\totos\\Desktop\\Data_Log_" + filename + ".csv";
                file = new FileInfo(path);
                using (StreamWriter sw = file.AppendText())
                {
                    sw.WriteLine(headings);
                }
                count = 0;
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
                    if (datapnt.Contains("TE"))
                    {
                        string msPassed = GetValue(datapnt);
                        fileTime = fileTime.AddMilliseconds(double.Parse(msPassed));
                        dataStream.Append(fileTime.ToString("HH:mm:ss:fff") + separator);
                    }
                    if (Trec)
                    {
                        if (datapnt.Contains("T01"))
                        {
                            if (checkBoxT1.Checked == true)
                            {
                                tbTemp1.Text = GetValue(datapnt);
                                dataStream.Append(tbTemp1.Text + separator);
                                addDataPnt(chartTemp, tempSens1, tbTemp1.Text);
                            }
                        }
                        else if (datapnt.Contains("T02"))
                        {
                            if (checkBoxT2.Checked == true)
                            {
                                tbTemp2.Text = GetValue(datapnt);
                                dataStream.Append(tbTemp2.Text + separator);
                                addDataPnt(chartTemp, tempSens2, tbTemp2.Text);
                            }
                        }
                        else if (datapnt.Contains("T03"))
                        {
                            if (checkBoxT3.Checked == true)
                            {
                                tbTemp3.Text = GetValue(datapnt);
                                dataStream.Append(tbTemp3.Text + separator);
                                addDataPnt(chartTemp, tempSens3, tbTemp3.Text);
                            }
                        }
                        else if (datapnt.Contains("T04"))
                        {
                            if (checkBoxT4.Checked == true)
                            {
                                tbTemp4.Text = GetValue(datapnt);
                                dataStream.Append(tbTemp4.Text + separator);
                                addDataPnt(chartTemp, tempSens4, tbTemp4.Text);
                            }
                        }
                        else if (datapnt.Contains("T05"))
                        {
                            if (checkBoxT5.Checked == true)
                            {
                                tbTemp5.Text = GetValue(datapnt);
                                dataStream.Append(tbTemp5.Text + separator);
                                addDataPnt(chartTemp, tempSens5, tbTemp5.Text);
                            }
                        }
                        else if (datapnt.Contains("T06"))
                        {
                            if (checkBoxT6.Checked == true)
                            {
                                tbTemp6.Text = GetValue(datapnt);
                                dataStream.Append(tbTemp6.Text + separator);
                                addDataPnt(chartTemp, tempSens6, tbTemp6.Text);
                            }
                        }
                    }
                    if (Prec)
                    {
                        if (datapnt.Contains("P01"))
                        {
                            if (checkBoxP1.Checked == true)
                            {
                                tbPress1.Text = GetValue(datapnt);
                                dataStream.Append(tbPress1.Text + separator);
                                addDataPnt(chartPress, pressSens1, tbPress1.Text);
                            }
                        }
                        else if (datapnt.Contains("P02"))
                        {
                            if (checkBoxP2.Checked == true)
                            {
                                tbPress2.Text = GetValue(datapnt);
                                dataStream.Append(tbPress2.Text + separator);
                                addDataPnt(chartPress, pressSens2, tbPress2.Text);
                            }
                        }
                        else if (datapnt.Contains("P03"))
                        {
                            if (checkBoxP3.Checked == true)
                            {
                                tbPress3.Text = GetValue(datapnt);
                                dataStream.Append(tbPress3.Text + separator);
                                addDataPnt(chartPress, pressSens3, tbPress3.Text);
                            }
                        }
                        else if (datapnt.Contains("P04"))
                        {
                            if (checkBoxP4.Checked == true)
                            {
                                tbPress4.Text = GetValue(datapnt);
                                dataStream.Append(tbPress4.Text + separator);
                                addDataPnt(chartPress, pressSens4, tbPress4.Text);
                            }
                        }
                        else if (datapnt.Contains("P05"))
                        {
                            if (checkBoxP5.Checked == true)
                            {
                                tbPress5.Text = GetValue(datapnt);
                                dataStream.Append(tbPress5.Text + separator);
                                addDataPnt(chartPress, pressSens5, tbPress5.Text);
                            }
                        }
                        else if (datapnt.Contains("P06"))
                        {
                            if (checkBoxP6.Checked == true)
                            {
                                tbPress6.Text = GetValue(datapnt);
                                dataStream.Append(tbPress6.Text + separator);
                                addDataPnt(chartPress, pressSens6, tbPress6.Text);
                            }
                        }
                    }
                    if (mouseUp)
                    {
                        if (datapnt.Contains("S01"))
                        {
                            tbFV1Pos.Text = GetValue(datapnt);
                            dataStream.Append(tbFV1Pos.Text + separator);
                            tbFV1State.Text = GetStateValue(datapnt);
                        }
                        else if (datapnt.Contains("S02"))
                        {
                            tbFV2Pos.Text = GetValue(datapnt);
                            dataStream.Append(tbFV2Pos.Text + separator);
                            tbFV2State.Text = GetStateValue(datapnt);
                        }
                        else if (datapnt.Contains("S03"))
                        {
                            tbFV3Pos.Text = GetValue(datapnt);
                            dataStream.Append(tbFV3Pos.Text + separator);
                            tbFV3State.Text = GetStateValue(datapnt);
                        }
                        else if (datapnt.Contains("S04"))
                        {
                            tbOV1Pos.Text = GetValue(datapnt);
                            dataStream.Append(tbOV1Pos.Text + separator);
                            tbOV1State.Text = GetStateValue(datapnt);
                        }
                        else if (datapnt.Contains("S05"))
                        {
                            tbOV2Pos.Text = GetValue(datapnt);
                            dataStream.Append(tbOV2Pos.Text + separator);
                            tbOV2State.Text = GetStateValue(datapnt);
                        }
                        else if (datapnt.Contains("S06"))
                        {
                            tbOV3Pos.Text = GetValue(datapnt);
                            dataStream.Append(tbOV3Pos.Text + separator);
                            tbOV3State.Text = GetStateValue(datapnt);
                        }
                        else if (datapnt.Contains("S07"))
                        {
                            tbNV1Pos.Text = GetValue(datapnt);
                            dataStream.Append(tbNV1Pos.Text + separator);
                            tbNV1State.Text = GetStateValue(datapnt);
                        }
                        else if (datapnt.Contains("S08"))
                        {
                            tbNV2Pos.Text = GetValue(datapnt);
                            dataStream.Append(tbNV2Pos.Text + separator);
                            tbNV2State.Text = GetStateValue(datapnt);
                        }
                        else if (datapnt.Contains("S09"))
                        {
                            tbPVPos.Text = GetValue(datapnt);
                            dataStream.Append(tbPVPos.Text + separator);
                            tbPVState.Text = GetStateValue(datapnt);
                        }
                        else if (datapnt.Contains("S10"))
                        {
                            tbFV4Pos.Text = GetValue(datapnt);
                            dataStream.Append(tbFV4Pos.Text + separator);
                            tbFV4State.Text = GetStateValue(datapnt);
                        }
                        else if (datapnt.Contains("S11"))
                        {
                            tbOV4Pos.Text = GetValue(datapnt);
                            dataStream.Append(tbOV4Pos.Text + separator);
                            tbOV4State.Text = GetStateValue(datapnt);
                        }
                    }
                }
                using (StreamWriter sw = file.AppendText())
                {
                    sw.WriteLine(dataStream.ToString());
                }
                try
                {
                    dataStream.Clear();
                }
                catch
                {
                    return;
                }
                if (count == 1)
                {
                    setSliderValues();
                    initServos();
                }
                count++;
            }
        }
        private void WriteSerial(string valve, string position)
        {
                mySerialPort.WriteLine(valve + ":" + position);
        }
        private void clearTBoxes()
        {
            // Clear the boxes containing the temperature data
            tbTemp1.Text = "";
            tbTemp2.Text = "";
            tbTemp3.Text = "";
            tbTemp4.Text = "";
            tbTemp5.Text = "";
            tbTemp6.Text = "";
        }
        private void clearPBoxes()
        {
            // Clear the boxes containing the pressure data
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
        private void clearTSeries()
        {
            foreach (var series in chartTemp.Series)
            {
                series.Points.Clear();
            }
        }
        private void clearPSeries()
        {
            foreach (var series in chartPress.Series)
            {
                series.Points.Clear();
            }
        }
        private void initServos()
        {
            drawServo(pbFV1, (int)BoxType.Threeway, tbFV1Pos.Text);
            drawServo(pbFV2, (int)BoxType.Horizontal, tbFV2Pos.Text);
            drawServo(pbFV3, (int)BoxType.Vertical, tbFV3Pos.Text);
            drawServo(pbFV4, (int)BoxType.Vertical, tbFV4Pos.Text);
            drawServo(pbOV1, (int)BoxType.Threeway, tbOV1Pos.Text);
            drawServo(pbOV2, (int)BoxType.Horizontal, tbOV2Pos.Text);
            drawServo(pbOV3, (int)BoxType.Vertical, tbOV3Pos.Text);
            drawServo(pbOV4, (int)BoxType.Vertical, tbOV4Pos.Text);
            drawServo(pbPV, (int)BoxType.Vertical, tbPVPos.Text);
            drawServo(pbNV1, (int)BoxType.Horizontal, tbNV1Pos.Text);
            drawServo(pbNV2, (int)BoxType.Horizontal, tbNV2Pos.Text);
        }
        private void drawServo(PictureBox pb, int boxType, string degrees)
        {
            drawArea = new Bitmap(pb.Size.Width, pb.Size.Height);
            int x = 0;
            int y = 0;
            int width = pb.Size.Width;
            int height = pb.Size.Height;
            float deg = float.Parse(degrees);

            Graphics g = Graphics.FromImage(drawArea);
            Pen myPen = new Pen(Color.Black, 2f);
            SolidBrush myBrush = new SolidBrush(Color.White);
            SolidBrush myBrush1 = new SolidBrush(Color.Black);

            g.FillRectangle(myBrush1, x, y, width, height);
            g.FillRectangle(myBrush, x + 2, y + 2, width - 4, height - 4);

            switch (boxType)
            {
                case (int)BoxType.Horizontal:
                    g.TranslateTransform(width / 2, height / 2);
                    g.RotateTransform(90 - deg);
                    g.TranslateTransform(-(width / 2), -(height / 2));
                    g.DrawRectangle(myPen, x + 4, y + 18, width - 8, 8);
                    g.FillRectangle(myBrush1, x + 4, y + 18, width - 8, 8);
                    break;
                case (int)BoxType.Vertical:
                    g.TranslateTransform(width / 2, height / 2);
                    g.RotateTransform(90 - deg);
                    g.TranslateTransform(-(width / 2), -(height / 2));
                    g.DrawRectangle(myPen, x + 18, y + 4, 8, height - 8);
                    g.FillRectangle(myBrush1, x + 18, y + 4, 8, height - 8);
                    break;
                case (int)BoxType.Threeway:
                    g.TranslateTransform(width / 2, height / 2);
                    g.RotateTransform(-deg / 2);
                    g.TranslateTransform(-(width / 2), -(height / 2));
                    g.DrawRectangle(myPen, x + 18, y + 4, 8, height / 2);
                    g.FillRectangle(myBrush1, x + 18, y + 4, 8, height / 2);
                    g.DrawRectangle(myPen, x + 18, y + 18, width / 2, 8);
                    g.FillRectangle(myBrush1, x + 18, y + 18, width / 2, 8);
                    break;
            }

            pb.Image = drawArea;
        }
        private void setSliderValues()
        {
            try
            {
                tbarFV1.Value = (int)double.Parse(tbFV1Pos.Text);
                tbarFV2.Value = (int)double.Parse(tbFV2Pos.Text);
                tbarFV3.Value = (int)double.Parse(tbFV3Pos.Text);
                tbarFV4.Value = (int)double.Parse(tbFV4Pos.Text);
                tbarOV1.Value = (int)double.Parse(tbOV1Pos.Text);
                tbarOV2.Value = (int)double.Parse(tbOV2Pos.Text);
                tbarOV3.Value = (int)double.Parse(tbOV3Pos.Text);
                tbarOV4.Value = (int)double.Parse(tbOV4Pos.Text);
                tbarPV.Value = (int)double.Parse(tbPVPos.Text);
                tbarNV1.Value = (int)double.Parse(tbNV1Pos.Text);
                tbarNV2.Value = (int)double.Parse(tbNV2Pos.Text);
            }
            catch
            {
                MessageBox.Show("The values are out of bounds of the slider.");
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
            clearTBoxes();
            clearPBoxes();
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
            clearTBoxes();
            clearPBoxes();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            mySerialPort.WriteLine("Reset");
            count = 0;
        }
        private void btnStartRec_Click(object sender, EventArgs e)
        {
            mySerialPort.WriteLine("SD");
            rec = true;
        }
        private void btnStopRec_Click(object sender, EventArgs e)
        {
            mySerialPort.WriteLine("StopRec");
            rec = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearTBoxes();
            clearPBoxes();
            clearTSeries();
            clearPSeries();
        }

        // Slider Scroll Events
        private void tbarFV1_Scroll(object sender, EventArgs e)
        {
            drawServo(pbFV1, (int)BoxType.Threeway, tbarFV1.Value.ToString());
            tbFV1Pos.Text = tbarFV1.Value.ToString();
        }
        private void tbarFV2_Scroll(object sender, EventArgs e)
        {
            drawServo(pbFV2, (int)BoxType.Horizontal, tbarFV2.Value.ToString());
            tbFV2Pos.Text = tbarFV2.Value.ToString();
        }
        private void tbarFV3_Scroll(object sender, EventArgs e)
        {
            drawServo(pbFV3, (int)BoxType.Horizontal, tbarFV3.Value.ToString());
            tbFV3Pos.Text = tbarFV3.Value.ToString();
        }
        private void tbarFV4_Scroll(object sender, EventArgs e)
        {
            drawServo(pbFV4, (int)BoxType.Horizontal, tbarFV4.Value.ToString());
            tbFV4Pos.Text = tbarFV4.Value.ToString();
        }
        private void tbarOV1_Scroll(object sender, EventArgs e)
        {
            drawServo(pbOV1, (int)BoxType.Threeway, tbarOV1.Value.ToString());
            tbOV1Pos.Text = tbarOV1.Value.ToString();
        }
        private void tbarOV2_Scroll(object sender, EventArgs e)
        {
            drawServo(pbOV2, (int)BoxType.Horizontal, tbarOV2.Value.ToString());
            tbOV2Pos.Text = tbarOV2.Value.ToString();
        }
        private void tbarOV3_Scroll(object sender, EventArgs e)
        {
            drawServo(pbOV3, (int)BoxType.Vertical, tbarOV3.Value.ToString());
            tbOV3Pos.Text = tbarOV3.Value.ToString();
        }
        private void tbarOV4_Scroll(object sender, EventArgs e)
        {
            drawServo(pbOV4, (int)BoxType.Vertical, tbarOV4.Value.ToString());
            tbOV4Pos.Text = tbarOV4.Value.ToString();
        }
        private void tbarPV_Scroll(object sender, EventArgs e)
        {
            drawServo(pbPV, (int)BoxType.Vertical, tbarPV.Value.ToString());
            tbPVPos.Text = tbarPV.Value.ToString();
        }
        private void tbarNV1_Scroll(object sender, EventArgs e)
        {
            drawServo(pbNV1, (int)BoxType.Horizontal, tbarNV1.Value.ToString());
            tbNV1Pos.Text = tbarNV1.Value.ToString();
        }
        private void tbarNV2_Scroll(object sender, EventArgs e)
        {
            drawServo(pbNV2, (int)BoxType.Horizontal, tbarNV2.Value.ToString());
            tbNV2Pos.Text = tbarNV2.Value.ToString();
        }

        // Slider Mouse Down Events
        private void tbarFV1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }
        private void tbarFV2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }
        private void tbarFV3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }
        private void tbarFV4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }
        private void tbarOV1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }
        private void tbarOV2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }
        private void tbarOV3_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }
        private void tbarOV4_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }
        private void tbarPV_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }
        private void tbarNV1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }
        private void tbarNV2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseUp = false;
        }

        // Slider Mouse Up Events
        private void tbarFV1_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial(Servo.FV1.ToString(), tbarFV1.Value.ToString());
            mouseUp = true;
        }
        private void tbarFV2_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial(Servo.FV2.ToString(), tbarFV2.Value.ToString());
            mouseUp = true;
        }
        private void tbarFV3_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial(Servo.FV3.ToString(), tbarFV3.Value.ToString());
            mouseUp = true;
        }
        private void tbarFV4_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial(Servo.FV4.ToString(), tbarFV4.Value.ToString());
            mouseUp = true;
        }
        private void tbarOV1_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial(Servo.OV1.ToString(), tbarOV1.Value.ToString());
            mouseUp = true;
        }
        private void tbarOV2_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial(Servo.OV2.ToString(), tbarOV2.Value.ToString());
            mouseUp = true;
        }
        private void tbarOV3_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial(Servo.OV3.ToString(), tbarOV3.Value.ToString());
            mouseUp = true;
        }
        private void tbarOV4_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial(Servo.OV4.ToString(), tbarOV4.Value.ToString());
            mouseUp = true;
        }
        private void tbarPV_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial(Servo.PV.ToString(), tbarPV.Value.ToString());
            mouseUp = true;
        }
        private void tbarNV1_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial(Servo.NV1.ToString(), tbarNV1.Value.ToString());
            mouseUp = true;
        }
        private void tbarNV2_MouseUp(object sender, MouseEventArgs e)
        {
            WriteSerial(Servo.NV2.ToString(), tbarNV2.Value.ToString());
            mouseUp = true;
        }

        // Combobox Events
        private void cbTempUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySerialPort.WriteLine("TempUnit:" + cbTempUnit.Text);
            Trec = false;
            if (cbTempUnit.Text.Contains("Celcius"))
            {
                chartTemp.ChartAreas["ChartArea1"].AxisY.Title = "Temperature [°C]";
            }
            else
            {
                chartTemp.ChartAreas["ChartArea1"].AxisY.Title = "Temperature [K]";
            }
            clearTBoxes();
            clearTSeries();
            Trec = true;
        }
        private void cbPressUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            mySerialPort.WriteLine("PressUnit:" + cbPressUnit.Text);
            Prec = false;
            if (cbPressUnit.Text.Contains("psi"))
            {
                chartPress.ChartAreas["ChartArea1"].AxisY.Title = "Pressure [psi]";
            }
            else
            {
                chartPress.ChartAreas["ChartArea1"].AxisY.Title = "Pressure [bar]";
            }
            clearPBoxes();
            clearPSeries();
            Prec = true;
        }
    }
}