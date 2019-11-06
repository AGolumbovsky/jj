using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jj
{
    public class MessWithArgs
    {
        public string MessWithAdapter()
        {
            Console.WriteLine("messing with adapter");

            string adapter = "\"Ethernet 6\"";
            return adapter;
        }

        public string MessWithStatDyn()
        {
            Console.WriteLine("messing with statDyn");

            string statDyn = "";

            switch (statDyn)
            {
                case "s":
                    statDyn = "static";
                    break;

                case "d":
                    statDyn = "dhcp";
                    break;

                default:
                    statDyn = "dhcp";
                    break;
            }

            return statDyn;
        }

        public string MessWithAddr()
        {
            Console.WriteLine("messing with addr");

            string addr = "7.7.7.7";

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

                case "icfff":   //don't show sensitive info in public repo. For now let's just do stars, ok?
                    addr = "****";
                    break;

                default:
                    addr = "8.8.8.8";
                    break;
            }


            return addr;
        }
    }
}
