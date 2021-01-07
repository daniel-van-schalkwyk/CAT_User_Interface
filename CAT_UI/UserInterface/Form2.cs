using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form2 : Form
    {
        public string COMPort;
        public string BRString;
        public int BaudRate;

        private void Form2_Load(object sender, EventArgs e)
        {
            getPortNames();
            cbCOM.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
            cbBaudRate.SelectedItem = "115200";
        }

        public Form2()
        {
            InitializeComponent();
        }

        // Methods
        public void getPortNames()
        {
            string[] ports = SerialPort.GetPortNames();
            cbCOM.Items.AddRange(ports);
        }

        // Button Events
        public void btnConnect_Click(object sender, EventArgs e)
        {
            COMPort = cbCOM.GetItemText(cbCOM.SelectedItem);
            BRString = cbBaudRate.GetItemText(cbBaudRate.SelectedItem);
            BaudRate = int.Parse(BRString);
            this.Hide();
        }
    }
}
