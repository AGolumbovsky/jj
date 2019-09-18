using System;
using System.Diagnostics;

namespace jj
{
    class Program
    {
        static void Main(string[] args)
        {

            var adapter = "\"Ethernet 8\""; // args[0];
            var sOrD = "static"; // args[1];
            // var addr = args[0];
            var subnet = "255.255.255.0"; // args[3];
            var defGway = "10.10.10.1"; // args[4];

            var addr = args[0];

            switch (addr)
            {
                case "192":
                    addr = "192.168.1.142";
                    break;

                case "172":
                    addr = "172.16.0.142";
                    break;

                case "10":
                    addr = "10.10.1.142";
                    break;

                default:
                    addr = "8.8.8.8";
                    break;
            }



            var formattedStr = "interface ip set address" + " " + adapter + " " + sOrD + " " + addr;

            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("netsh", formattedStr);
            p.StartInfo = psi;
            p.Start();

            Console.WriteLine(formattedStr);

        }
    }
}
