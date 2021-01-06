using System;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace ReadSerialV2
{
    class Program
    {
        static void Main(string[] args)
        {
            SerialPort myport = new SerialPort("COM11", 9600);

            try
            {
                myport.Open();

                while (true)
                {
                    string line = myport.ReadExisting();
                    Console.WriteLine($"Line: {line}");
                    Thread.Sleep(500);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
