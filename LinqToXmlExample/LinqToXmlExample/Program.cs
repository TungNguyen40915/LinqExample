using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinqToXmlExample
{
    class Program
    {
        static void Main(string[] args)
        {
            XNamespace empNM = "urn:lst-emp:emp";

            XDocument xDoc = new XDocument(
                        new XDeclaration("1.0", "UTF-16", null),
                        new XElement(empNM + "Employees",
                            new XElement("Employee",
                                new XComment("Only 3 elements for demo purposes"),
                                new XElement("EmpId", "5"),
                                new XElement("Name", "Kimmy"),
                                new XElement("Sex", "Female")
                                )));

            StringWriter sw = new StringWriter();
            xDoc.Save(sw);
            Console.WriteLine(sw);
            Console.ReadLine();
        }
    }
}
