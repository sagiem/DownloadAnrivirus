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
            webclient.DownloadFile(new Uri("https://devbuilds.s.kaspersky-labs.com/devbuilds/KVRT/latest/full/KVRT.exe"), "kaspersky.exe");
            webclient.DownloadFile(new Uri("http://www.freedrweb.com/download+cureit/gr/?lng=ru"), "DrWeb.exe");
        }
    }
}
