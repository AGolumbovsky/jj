using System;
using System.Diagnostics;

namespace jj
{
    class Program
    {
        static void Main(string[] args)
        {
            string adapter = "Ethernet 6";
            var sOrD = "sOrD";
            string addr = "8.8.8.8";

            var subnet = "255.255.255.0"; // args[3];
            var defGway = "10.10.10.1"; // args[4];

            var queryStr = "interface ip"; // set address" + " " + adapter + " " + sOrD + " " + addr;
            var setAddr = "set address";
            var showConfig = "show config";


            switch (args.Length)
            {
                case 0:
                    queryStr = "interface ip" +  " " + showConfig;
                    break;

                case 1:
                    adapter = args[0];
                    queryStr = "interface ip" + " " + setAddr + " " + adapter + " dhcp";
                    break;

                case 2:
                    adapter = args[0];
                    break;

            }

            
          

            /*switch (adapter)
            {
                case "e6":
                    adapter = "\"Ethernet 6\"";
                    break;

                case "e8":
                    adapter = "\"Ethernet 8\"";
                    break;

                case "w":
                    adapter = "Wi-Fi";
                    break;

                default: 
                    adapter = "\"Ethernet 6\"";
                    break;
            }*/

            switch (sOrD)
            {
                case "s":
                    sOrD = "static";
                    break;

                case "d":
                    sOrD = "dhcp";
                    addr = " "; 
                    break;

                default:
                    sOrD = "dhcp";
                    break;
            }

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
                // !!!!!!!! don't leave it like this, it will blow up in your face before you know it
                case "d":
                    sOrD = "dhcp";
                    addr = "";
                    break;

                case "icfff":   //don't show sensitive info in public repo. For now let's just do stars, ok?
                    addr = "****";
                    break;

                default:
                    addr = "8.8.8.8";
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
