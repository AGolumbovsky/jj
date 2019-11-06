using System;
using System.Diagnostics;


namespace jj
{
    class Program
    {
        static void Main(string[] args)
        {
            MessWithArgs arrgs = new MessWithArgs();

            var adapter = arrgs.MessWithAdapter();
            var statDyn = arrgs.MessWithStatDyn();
            string addr = arrgs.MessWithAddr();

            var subnet = "255.255.255.0"; // args[3];
            var defGway = "10.10.10.1"; // args[4];

            var queryStr = "query string is empty"; // set address" + " " + adapter + " " + sOrD + " " + addr;
            var setAddr = "set address";
           // var showConfig = "show config";

            // make shorthand for adapter
            switch (adapter)
            {
                case "e6":
                    adapter = "\"Ethernet 6\"";
                    break;

                case "e8":
                    adapter = "\"Ethernet 8\"";
                    break;

                case "w":
                    adapter = "\"Wi-Fi\"";
                    break;

                default: 
                    adapter = "\"" + adapter  + "\"";
                    break;
            }

            switch (args.Length)
            {
                case 0:
                    Console.WriteLine("Hi, I'm jj, what is your name? Wait, don't tell me, I don't care...");
                    break;

                case 1:
                    adapter = args[0];
                    queryStr = "interface ip set address " + adapter + " dhcp";
                    break;

                case 2:
                    adapter = args[0];
                    break;
            }

            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("netsh", queryStr);
            p.StartInfo = psi;
            p.Start();

            Console.WriteLine(queryStr);

        }
    }
}
