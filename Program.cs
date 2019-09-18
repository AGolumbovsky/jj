using System;
using System.Diagnostics;

namespace jj
{
    class Program
    {
        static void Main(string[] args)
        {

            var adapter = "Wi-Fi"; // args[0];
            var sOrD = "static"; // args[1];
            var addr = args[0];
            var subnet = "255.255.255.0"; // args[3];
            var defGway = "10.10.10.1"; // args[4];

            if (addr == "a")
            {
                addr = "192.168.55.55";
            }
            else if (addr == "b")
            {
                addr = "10.55.55.55";
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
