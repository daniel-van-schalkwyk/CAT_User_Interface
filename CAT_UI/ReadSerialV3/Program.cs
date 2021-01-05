using System;
using System.Diagnostics;
using System.IO.Ports;
using System.Threading;

namespace ReadSerialV3
{
    class Program
    {
        static SerialPort myport;
        static void Main(string[] args)
        {
            myport = new SerialPort("COM11", 9600);
            while (true)
            {
                //Debug.WriteLine("Incoming data: ");
                myport.Open();
                string data = myport.ReadLine();
                string[] splitdata = data.Split(',');
                foreach (var word in splitdata)
                {
                    if (word.Contains("T01"))
                    {
                        string[] datapnt = word.Split(':');
                        Debug.WriteLine("Temp Sensor 1: " + datapnt[1]);
                    }
                }
                Thread.Sleep(500);
                myport.Close();
            }
        }
    }
}
