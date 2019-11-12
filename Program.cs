using System;
using System.Diagnostics;


namespace jj
{
    class Program
    {
        static void Main(string[] args)
        {
            MessWithArgs formattedArgs = new MessWithArgs();

            // string adapter = formattedArgs.MessWithAdapter();
            // Console.WriteLine("adapter is " + adapter);

            string adapter = "defaultAdapter";

            string statDyn = "default statDyn";
            string addr = formattedArgs.MessWithAddr();
            string subnet = "255.255.255.0"; // args[3];
            string gway = "10.10.10.1"; // args[4];

            var queryStr = "query string is empty"; // set address" + " " + adapter + " " + statDyn + " " + addr;
          
           // var showConfig = "show config";

            switch (args.Length)
            {
                // as default behavior, will change Ethernet 6 to dhcp
                case 0:
                    Console.WriteLine("no parameters specified, setting Ethernet 6 to DHCP...");
                    adapter = "Ethernet 6";
                    queryStr = "interface ip set address \"Ethernet 6\" dhcp";

                    break;

                // will only mess with the adapter, Ethernet 6 is default
                // will need parenthesis to group a 2-part name, it is handled in MessWithArgs.MessWithAdapter()
                case 1:
                    // adapter = args[0];
                    adapter = formattedArgs.MessWithAdapter(args[0]);
                    queryStr = "interface ip set address " + adapter + " dhcp";
                    break;

                case 2:
                    adapter = formattedArgs.MessWithAdapter(args[0]);
                    statDyn = formattedArgs.MessWithStatDyn(args[1]);
                    queryStr = "interface ip set address " + adapter + " " + statDyn;
                    break;

                default:
                    Console.WriteLine("default case in args.Length");
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
