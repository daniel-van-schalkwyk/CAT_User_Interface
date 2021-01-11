using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Drawing_Test
{
    public partial class Form1 : Form
    {
        public double CenterX { get; set; }
        public double CenterY { get; set; }
        public delegate void writeText(string x);
        string degrees = "0";
        public Form1()
        {
            InitializeComponent();
            serialPort1 = new SerialPort("COM8", 115200);
            serialPort1.DtrEnable = true;
            serialPort1.Open();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string line = serialPort1.ReadLine();
            this.BeginInvoke(new writeText(WriteData), new object[] { line });
            paintServo(400, 300, 100, 100);
        }
        private void WriteData(string line)
        {
            string[] splitdata = line.Split(',');
            string[] s1 = splitdata[14].Split(':');
            degrees = s1[1];
            textBox1.Text = degrees;     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string state = tbInput.Text;
            if (state.Contains("Isolate"))
            {
                serialPort1.WriteLine("FV1:I");
            }
            else if (state.Contains("Feed"))
            {
                serialPort1.WriteLine("FV1:F");
            }
            else if (state.Contains("Vent"))
            {
                serialPort1.WriteLine("FV1:V");
            }
        }
        
        private void paintServo(int x, int y, int width, int height)
        {
            float centerX = x + width / 2;
            float centerY = y + height / 2;
            float deg = float.Parse(degrees);

            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            Pen pen = new Pen(Color.Black, 2f);
            SolidBrush brush = new SolidBrush(Color.Black);
            g.DrawRectangle(pen, x, y, width, height);
            g.TranslateTransform(centerX, centerY);
            g.RotateTransform(deg);
            g.TranslateTransform(-centerX, -centerY);
            g.DrawRectangle(pen, x + (4 * width) / 10, y, width / 5, height);
            g.FillRectangle(brush, x + (4 * width) / 10, y, width / 5, height);
            g.DrawRectangle(pen, x, y + (4 * height) / 10, (6 * width) / 10, height / 5);
            g.FillRectangle(brush, x, y + (4 * height) / 10, (6 * width) / 10, height / 5);
        }
    }
}
