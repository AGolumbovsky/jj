using System;
using System.IO;
using System.Xml;

using System.Linq;
using System.Xml.Linq;

public class HandleXml
{
    static XDocument doc = XDocument.Load("C:/Users/agolumbovsky/ag_code/CS/jj/Aliases.xml");
    public static void GetAddrFromXmlFile()
    {
        var addrAlias = "192";
        var addr = "default addr";

        var query =
            from entry in doc.Root.Descendants("addr")
            where (entry.Element("alias").Value).Contains(addrAlias)
            select entry.Element("value").Value;

        foreach (var i in query)
        {
            Console.WriteLine("Test addr " + i);
            addr = i;
        }    
    }

    public static void GetAdapterFromXmlFile()
    {
        var adapterAlias = "e6";
        var adapter = "default adapter";

        var query =
             from entry in doc.Root.Descendants("adapter")
             where (entry.Element("alias").Value).Contains(adapterAlias)
             select entry.Element("value").Value;

        foreach (var i in query)
        {
            Console.WriteLine("Test Adapter " + i);
            adapter = i;
        }
    }

    public static void GetMaskFromXmlFile()
    {
        var maskAlias = "24";
        var mask = "255.255.255.0";

        var query =
            from entry in doc.Root.Descendants("mask")
            where (entry.Element("alias").Value).Contains(maskAlias)
            select entry.Element("value").Value;

        foreach (var i in query)
        {
            Console.WriteLine("Test mask " + i);
            mask = i;
        }
    }

}

