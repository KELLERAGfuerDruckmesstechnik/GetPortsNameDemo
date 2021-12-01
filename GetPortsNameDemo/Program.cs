using System;
using System.IO.Ports;

namespace GetPortsNameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start Suche nach existierenden Port-Namen...");
            try
            {
                var portNames = SerialPort.GetPortNames();
                Console.WriteLine("... Gefunden wurden " + portNames.Length + " Ports: ");

                foreach (string portName in portNames)
                {
                    Console.WriteLine(" - '" + portName + "'");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("FEHLER: " + e);
            }
            Console.WriteLine("Ende des Programms. Bitte diesen Text kopieren und per Mail and KELLER senden!");
            Console.ReadLine();
        }
    }
}
