

// ALL BElOW CODE IS FROM MS EXAMPLES, MAKE YOUR OWN DAMN CODE !!!!!

using System;
using System.IO;
using System.Xml;

using System.Linq;

public class HandleXml
{
    public void ReadFromXmlFile()
    {
        //Create the XmlDocument.
        XmlDocument doc = new XmlDocument();
        doc.Load("C:/Users/agolumbovsky/ag_code/CS/jj/Aliases.xml"); //changing doc.LoadXml() to doc.Load()

        //Display the document element.
        Console.WriteLine(doc.DocumentElement.OuterXml);

        /*
            var meh =
            from entry in doc
            select entry;
            
         */
    }
}