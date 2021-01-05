using System;
using System.IO.Ports;
using System.Threading;

namespace ReadSerialV3
{
    class Program
    {
        static SerialPort myport;
        static void Main(string[] args)
        {
            myport = new SerialPort("COM8", 9600);
            while (true)
            {
                Console.Write("Incoming data: ");
                myport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                myport.Open();
                Thread.Sleep(500);
            }
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine(myport.ReadExisting());
        }
    }
}
