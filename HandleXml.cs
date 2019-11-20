

// ALL BElOW CODE IS FROM MS EXAMPLES, MAKE YOUR OWN DAMN CODE !!!!!

using System;
using System.IO;
using System.Xml;

public class HandleXml
{
    public void SomeFn()
    {
        //Create the XmlDocument.
        XmlDocument doc = new XmlDocument();
        doc.LoadXml("<?xml version='1.0' ?>" +
                    "<book genre='novel' ISBN='1-861001-57-5'>" +
                    "<title>Pride And Prejudice</title>" +
                    "</book>");

        //Display the document element.
        Console.WriteLine(doc.DocumentElement.OuterXml);
    }
}