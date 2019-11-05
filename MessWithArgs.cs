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

            string statDyn = "static";
            return statDyn;
        }

        public string MessWithAddr()
        {
            Console.WriteLine("messing with addr");

            string addr = "7.7.7.7";
            return addr;
        }
    }
}
