using System;
using System.IO;
using System.Xml;

using System.Linq;
using System.Xml.Linq;

public class HandleXml
{
    public void ReadFromXmlFile()
    {
        //Create the XmlDocument.
        var doc = XDocument.Load("C:/Users/agolumbovsky/ag_code/CS/jj/Aliases.xml");
        // doc.Load("C:/Users/agolumbovsky/ag_code/CS/jj/Aliases.xml"); //changing doc.LoadXml() to doc.Load()

        //Display the document element.
        // Console.WriteLine(doc.Descendants("adapter"));



        // string[] xmlAliases = { "unoAlias", "dosAlias", "tresAlias" };
        var myId = "192";

        var query =
            from entry in doc.Root.Descendants("addr")
            where (entry.Element("alias").Value).Contains(myId)
            select entry.Element("value").Value;

        foreach (var i in query)
        {
            Console.Write("here: " + i + "\n");
        }

        // Console.WriteLine(typeof(query));


       /* // Loading from a file, you can also load from a stream
        var xml = XDocument.Load(@"C:\contacts.xml");


        // Query the data and write out a subset of contacts
        var query = from c in xml.Root.Descendants("contact")
                    where (int)c.Attribute("id") < 4
                    select c.Element("firstName").Value + " " +
                           c.Element("lastName").Value;


        foreach (string name in query)
        {
            Console.WriteLine("Contact's Full Name: {0}", name);
        }// Loading from a file, you can also load from a stream
        var xml = XDocument.Load(@"C:\contacts.xml");


        // Query the data and write out a subset of contacts
        var query = from c in xml.Root.Descendants("contact")
                    where (int)c.Attribute("id") < 4
                    select c.Element("firstName").Value + " " +
                           c.Element("lastName").Value;


        foreach (string name in query)
        {
            Console.WriteLine("Contact's Full Name: {0}", name);
        }*/

    }
}

/*XElement xelement = XElement.Load("..\\..\\Employees.xml");
IEnumerable<XElement> employees = xelement.Elements();
Console.WriteLine("List of all Employee Names :");
foreach (var employee in employees)
{
    Console.WriteLine(employee.Element("Name").Value);
}*/