using System;
using System.Diagnostics;


namespace jj
{
    class Program
    {
        static void Main(string[] args)
        {
            MessWithArgs arrgs = new MessWithArgs();

            string adapter = arrgs.MessWithAdapter();
            string statDyn = arrgs.MessWithStatDyn();
            string addr = arrgs.MessWithAddr();
            string subnet = "255.255.255.0"; // args[3];
            string gway = "10.10.10.1"; // args[4];

            var queryStr = "query string is empty"; // set address" + " " + adapter + " " + statDyn + " " + addr;
          
           // var showConfig = "show config";

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
