using System;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var webclient = new WebClient();
            webclient.Proxy = null;
            Console.WriteLine("Идет загрузка");
            webclient.DownloadFile(new Uri("https://devbuilds.s.kaspersky-labs.com/devbuilds/KVRT/latest/full/KVRT.exe"), "kaspersky.exe");
        }
    }
}
