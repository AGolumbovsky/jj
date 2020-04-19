using System;
using System.Diagnostics;
using System.Security.Principal;


namespace jj
{
    class Program
    {
        static void Main(string[] args)
        {
            //check if app is running in Admin mode and prompt user if not
            void WarnIfNotAdmin()
            {
                var isAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent())
                          .IsInRole(WindowsBuiltInRole.Administrator);
                if (!isAdmin)
                {
                    Console.WriteLine("You not Admin, you have to be Admin");
                }
            }
            WarnIfNotAdmin();

            string adapter = "defaultAdapter";
            string addr = "default address";
            string subnet = "255.255.255.0"; // args[3];
            string gway = "10.10.10.1"; // args[4];

            var queryStr = "empty query string"; // set address" + " " + adapter + " " + statDyn + " " + addr;

            // var showConfig = "show config";

            HandleArgs.CreateAliasFromXml();

            switch (args.Length)
            {
                // as default behavior, will change Ethernet 6 to dhcp
                case 0:
                    Console.WriteLine("no parameters specified, setting Ethernet 6 to DHCP...");
                    adapter = "Ethernet 6";
                    queryStr = "interface ip set address \"Ethernet 6\" dhcp";

                    break;

                // will only mess with the adapter, Ethernet 6 is default
                // needs parenthesis to group a 2-word name, it is handled in formattedArgs.FormatAdapter()
                case 1:
                    if (args[0] == "show")
                    {
                        queryStr = "interface ip show config";
                    }
                    else
                    {
                    adapter = HandleArgs.FormatAdapter(args[0]);
                    queryStr = "interface ip set address " + adapter + " dhcp";
                    }
                    break;

                case 2:
                    adapter = HandleArgs.FormatAdapter(args[0]);
                    addr = HandleArgs.FormatAddr(args[1]);
                    queryStr = "interface ip set address " + adapter + " " + addr;
                    break;

                default:
                    Console.WriteLine("default case in args.Length");
                    break;
            }

            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo("netsh", queryStr);


            /* *** This should make sure that no new window is open when the process starts *** */
            // -------------

            //psi.WindowStyle = ProcessWindowStyle.Hidden;
            //psi.RedirectStandardOutput = true;
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;

            p.StartInfo = psi;
            p.Start();

            Console.WriteLine("netsh query string is: " + "***" + queryStr + "***");
        }
    }
}
