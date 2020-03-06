using System;
using System.IO;
using System.Xml;

using System.Linq;
using System.Xml.Linq;

public class HandleXml
{
    XDocument doc = XDocument.Load("C:/Users/agolumbovsky/ag_code/CS/jj/Aliases.xml");
    public void ReadFromXmlFile()
    {
        // doc.Load("C:/Users/agolumbovsky/ag_code/CS/jj/Aliases.xml"); //changing doc.LoadXml() to doc.Load()

        //Display the document element.
        // Console.WriteLine(doc.Descendants("adapter"));

        // string[] xmlAliases = { "unoAlias", "dosAlias", "tresAlias" };
        var addrAlias = "192";
        var adapterAlias = "e6";

        var query =
            from entry in doc.Root.Descendants("addr")
            where (entry.Element("alias").Value).Contains(addrAlias)
            select entry.Element("value").Value;

        foreach (var i in query)
        {
            Console.Write("here: " + i + "\n");
        }    
    }

}
