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
            myport.Open();
            while (true)
            {
                byte a = (byte)myport.ReadByte();
                Console.Write(a);
                Thread.Sleep(1000);
            }
        }
    }
}
