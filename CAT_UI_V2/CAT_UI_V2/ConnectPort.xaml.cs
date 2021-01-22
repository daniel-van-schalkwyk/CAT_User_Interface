using System;
using System.Windows;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CAT_UI_V2
{
    /// <summary>
    /// Interaction logic for ConnectPort.xaml
    /// </summary>
    public partial class ConnectPort : Window
    {
        public string COMPort;
        public int BaudRate;
        private string[] BaudRates = { "1200", "2400", "4800", "9600", "14400", "19200", "57600", "115200", "128000", "256000" };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] Portnames = GetPortNames();
            cbCOMPort.ItemsSource = Portnames;
            cbCOMPort.SelectedIndex = Portnames.Length - 1;
            cbBaudRate.ItemsSource = BaudRates;
            cbBaudRate.SelectedItem = "115200";
        }

        public ConnectPort()
        {
            InitializeComponent();
            
        }

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                COMPort = cbCOMPort.SelectedItem.ToString();
                BaudRate = int.Parse(cbBaudRate.SelectedItem.ToString());
                this.Hide();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string[] GetPortNames()
        {
            string[] names = SerialPort.GetPortNames();
            return names;
        }
    }
}
