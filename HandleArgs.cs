using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace jj
{
    public class HandleArgs
    {

        public void CreateAliasFromXml()
        {

            HandleXml Xmlr = new HandleXml();
            Xmlr.ReadFromXmlFile();
        }

        public string FormatAdapter(string adapter)
        {
            switch (adapter)
            {
                case "e6":
                    adapter = "\"Ethernet 6\"";
                    break;

                case "e8":
                    adapter = "\"Ethernet 8\"";
                    break;

                case "e12":
                    adapter = "\"Ethernet 12\"";
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

        public string FormatAddr(string addr)
        {
            switch (addr) 
            {
                case "d":
                    addr = "dhcp";
                    break;

                case "192":
                    addr = "static 192.168.0.89";
                    break;

                case "172":
                    addr = "static 172.16.0.193";
                    break;

                case "10":
                    addr = "static 10.10.1.193";
                    break;

                case "icfff":   //don't show sensitive info in public repo. For now let's just do stars, ok?
                    // yablochko.chmo.ochko.*
                    addr = "static 1.2.3.4";
                    break;

                default:
                    addr = "static" + " " + addr; // watch the spaces, they can easily break it
                    break;
            }

            return addr;
        }
    }
}
