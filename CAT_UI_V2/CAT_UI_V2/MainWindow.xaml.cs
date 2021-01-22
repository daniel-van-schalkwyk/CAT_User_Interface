using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Windows;
using System.Threading;
using System.Windows.Threading;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Forms.DataVisualization.Charting;

namespace CAT_UI_V2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Variable declarations
        private bool slide = true;
        private int count;
        private List<Series> TSeriesList = new List<Series>();
        private List<Series> PSeriesList = new List<Series>();
        private List<CheckBox> cbList = new List<CheckBox>();

        private Series t1 = new Series();
        private Series t2 = new Series();
        private Series t3 = new Series();
        private Series t4 = new Series();
        private Series t5 = new Series();
        private Series t6 = new Series();

        private Series p1 = new Series();
        private Series p2 = new Series();
        private Series p3 = new Series();
        private Series p4 = new Series();
        private Series p5 = new Series();
        private Series p6 = new Series();

        // Object declarations
        private SerialPort Sp = new SerialPort();
        private ConnectPort Cp = new ConnectPort();
        private MySerialData Sd = new MySerialData();
        private Drawings Dr = new Drawings();
        private DataLogging Dl = new DataLogging();
        private Charts Ch = new Charts();

        // Delegate declaration
        private delegate void DataDeleg(string x);
        private delegate void SeriesDeleg(Chart c, Series s, string x, int count, CheckBox cb);

        private void Window_Load(object sender, RoutedEventArgs e)
        {
            Cp.Show();
            Cp.Topmost = true;

            cbList.Add(cbPressSens1);
            cbList.Add(cbPressSens2);
            cbList.Add(cbPressSens3);
            cbList.Add(cbPressSens4);
            cbList.Add(cbPressSens5);
            cbList.Add(cbPressSens6);

            cbList.Add(cbTempSens1);
            cbList.Add(cbTempSens2);
            cbList.Add(cbTempSens3);
            cbList.Add(cbTempSens4);
            cbList.Add(cbTempSens5);
            cbList.Add(cbTempSens6);

            Ch.ChartInit(tChart, 0);
            Ch.ChartInit(pChart, 1);

            TSeriesList.Add(t1);
            TSeriesList.Add(t2);
            TSeriesList.Add(t3);
            TSeriesList.Add(t4);
            TSeriesList.Add(t5);
            TSeriesList.Add(t6);

            PSeriesList.Add(p1);
            PSeriesList.Add(p2);
            PSeriesList.Add(p3);
            PSeriesList.Add(p4);
            PSeriesList.Add(p5);
            PSeriesList.Add(p6);

            foreach (Series s in TSeriesList)
            {
                Ch.SeriesInit(s, tChart);
            }
            foreach(Series s in PSeriesList)
            {
                Ch.SeriesInit(s, pChart);
            }
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Cp.Close();
        }

        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Maximized;

            Cp.btnConnect.Click += new RoutedEventHandler(ConnectPortEventHandler);
        }

        // Event Handlers
        private void ConnectPortEventHandler(object sender, RoutedEventArgs e)
        {
            ConnectPort();
            Sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string line = sp.ReadLine();
            Dl.AppendText(line);
            Dispatcher.Invoke(new DataDeleg(WriteData), line);
            int count = 0;
            foreach (Series s in PSeriesList)
            {
                Dispatcher.Invoke(new SeriesDeleg(Ch.AddPoint), pChart, s, line, count, cbList[count]);
                count++;
            }
            foreach (Series s in TSeriesList)
            {
                Dispatcher.Invoke(new SeriesDeleg(Ch.AddPoint), tChart, s, line, count, cbList[count]);
                count++;
            }
        }

        // Methods
        private void ConnectPort()
        {
            try
            {
                Sp.PortName = Cp.COMPort;
                Sp.BaudRate = Cp.BaudRate;
                Sp.DtrEnable = true;
                Sp.Open();
                count = 2;
                Dl.OpenFile();
                Ch.SetTime();
            }
            catch
            {
                MessageBox.Show("Port was unable to connect!");
                Cp.Show();
            }
        }
        private void WriteData(string x)
        {
            // Temperature sensors
            tbTempSens1.Text = Sd.GetData(x, "T01");
            tbTempSens2.Text = Sd.GetData(x, "T02");
            tbTempSens3.Text = Sd.GetData(x, "T03");
            tbTempSens4.Text = Sd.GetData(x, "T04");
            tbTempSens5.Text = Sd.GetData(x, "T05");
            tbTempSens6.Text = Sd.GetData(x, "T06");

            // Pressure sensors
            tbPressSens1.Text = Sd.GetData(x, "P01");
            tbPressSens2.Text = Sd.GetData(x, "P02");
            tbPressSens3.Text = Sd.GetData(x, "P03");
            tbPressSens4.Text = Sd.GetData(x, "P04");
            tbPressSens5.Text = Sd.GetData(x, "P05");
            tbPressSens6.Text = Sd.GetData(x, "P06");

            // Servos
            if (slide)
            {
                tbFV1.Text = Sd.GetData(x, "S01");
                tbFV1S.Text = Sd.GetData(x, "S01", 1);
                tbFV2.Text = Sd.GetData(x, "S02");
                tbFV2S.Text = Sd.GetData(x, "S02", 1);
                tbFV3.Text = Sd.GetData(x, "S03");
                tbFV3S.Text = Sd.GetData(x, "S03", 1);
                tbFV4.Text = Sd.GetData(x, "S10");
                tbFV4S.Text = Sd.GetData(x, "S10", 1);
                tbOV1.Text = Sd.GetData(x, "S04");
                tbOV1S.Text = Sd.GetData(x, "S04", 1);
                tbOV2.Text = Sd.GetData(x, "S05");
                tbOV2S.Text = Sd.GetData(x, "S05", 1);
                tbOV3.Text = Sd.GetData(x, "S06");
                tbOV3S.Text = Sd.GetData(x, "S06", 1);
                tbOV4.Text = Sd.GetData(x, "S11");
                tbOV4S.Text = Sd.GetData(x, "S11", 1);
                tbNV1.Text = Sd.GetData(x, "S07");
                tbNV1S.Text = Sd.GetData(x, "S07", 1);
                tbNV2.Text = Sd.GetData(x, "S08");
                tbNV2S.Text = Sd.GetData(x, "S08", 1);
                tbPV.Text = Sd.GetData(x, "S09");
                tbPVS.Text = Sd.GetData(x, "S09", 1);
            }
            if (count == 2)
            {
                InitServos();
            }
            count++;
        }
        private void InitServos()
        {
            slFV1.Value = double.Parse(tbFV1.Text);
            Dr.DrawServo(cFV1, (double)slFV1.Value, 1);
            slFV2.Value = double.Parse(tbFV2.Text);
            Dr.DrawServo(cFV2, (double)slFV2.Value, 0);
            slFV3.Value = double.Parse(tbFV3.Text);
            Dr.DrawServo(cFV3, (double)slFV3.Value, 2);
            slFV4.Value = double.Parse(tbFV4.Text);
            Dr.DrawServo(cFV4, (double)slFV4.Value, 2);

            slOV1.Value = double.Parse(tbOV1.Text);
            Dr.DrawServo(cOV1, (double)slOV1.Value, 1);
            slOV2.Value = double.Parse(tbOV2.Text);
            Dr.DrawServo(cOV2, (double)slOV2.Value, 0);
            slOV3.Value = double.Parse(tbOV3.Text);
            Dr.DrawServo(cOV3, (double)slOV3.Value, 2);
            slOV4.Value = double.Parse(tbOV4.Text);
            Dr.DrawServo(cOV4, (double)slOV4.Value, 2);

            slNV1.Value = double.Parse(tbNV1.Text);
            Dr.DrawServo(cNV1, (double)slNV1.Value, 0);
            slNV2.Value = double.Parse(tbNV2.Text);
            Dr.DrawServo(cNV2, (double)slNV2.Value, 0);

            slPV.Value = double.Parse(tbPV.Text);
            Dr.DrawServo(cPV, (double)slPV.Value, 2);
        }

        // Button Events
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            Sp.WriteLine("Reset");
            count = 0;
        }
        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Cp.Show();
                Cp.Topmost = true;
            }
            catch
            {
                MessageBox.Show("The Connect Window has been closed. Reload the application.");
            }
        }
        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            Sp.WriteLine("S");
        }
        private void btnStartDS_Click(object sender, RoutedEventArgs e)
        {
            Thread.Sleep(500);
            Sp.WriteLine("Sd");
        }

        // Slider Events
        private void slFV1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbFV1.Text = slFV1.Value.ToString();
            Dr.DrawServo(cFV1, (double)slFV1.Value, 1);
        }
        private void slFV2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbFV2.Text = slFV2.Value.ToString();
            Dr.DrawServo(cFV2, (double)slFV2.Value, 0);
        }
        private void slFV3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbFV3.Text = slFV3.Value.ToString();
            Dr.DrawServo(cFV3, (double)slFV3.Value, 2);
        }
        private void slFV4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbFV4.Text = slFV4.Value.ToString();
            Dr.DrawServo(cFV4, (double)slFV4.Value, 2);
        }
        private void slOV1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbOV1.Text = slOV1.Value.ToString();
            Dr.DrawServo(cOV1, (double)slOV1.Value, 1);
        }
        private void slOV2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbOV2.Text = slOV2.Value.ToString();
            Dr.DrawServo(cOV2, (double)slOV2.Value, 0);
        }
        private void slOV3_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbOV3.Text = slOV3.Value.ToString();
            Dr.DrawServo(cOV3, (double)slOV3.Value, 2);
        }
        private void slOV4_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbOV4.Text = slOV4.Value.ToString();
            Dr.DrawServo(cOV4, (double)slOV4.Value, 2);
        }
        private void slNV1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbNV1.Text = slNV1.Value.ToString();
            Dr.DrawServo(cNV1, (double)slNV1.Value, 0);
        }
        private void slNV2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbNV2.Text = slNV2.Value.ToString();
            Dr.DrawServo(cNV2, (double)slNV2.Value, 0);
        }
        private void slPV_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tbPV.Text = slPV.Value.ToString();
            Dr.DrawServo(cPV, (double)slPV.Value, 2);
        }

        private void sl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            slide = false;
        }
        private void sl_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Slider slider = (Slider)sender;
            string name = slider.Name.Substring(2);
            string value = slider.Value.ToString();
            Sp.WriteLine(string.Format("{0}:{1}", name, value));
            slide = true;
        }
    }
}
