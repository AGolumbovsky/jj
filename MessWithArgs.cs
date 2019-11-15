using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jj
{
    public class MessWithArgs
    { 
        public string MessWithAdapter(string adapter)
        {
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
                    adapter = "\"" + adapter + "\"";
                    break;
            }


            return adapter;
        }

        public string MessWithAddr(string addr)
        {
            switch (addr)
            {
                case "d":
                    addr = "dhcp";
                    break;

                case "192":
                    addr = "static 192.168.1.193";
                    break;

                case "172":
                    addr = "static 172.16.0.193";
                    break;

                case "10":
                    addr = "static 10.10.1.193";
                    break;

                case "icfff":   //don't show sensitive info in public repo. For now let's just do stars, ok?
                    addr = "static 1.2.3.4";
                    break;

                default:
                    addr = "static 8.8.8.8";
                    break;
            }

            return addr;
        }
    }
}
