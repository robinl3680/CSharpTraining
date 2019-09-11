using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StoredProcedureExample
{
    class Program
    {

        static string DisplayText(XmlReader xReader)
        {
            string text = null;
            xReader.Read();
            if (xReader.NodeType == XmlNodeType.Text)
            {
                //Console.WriteLine(xReader.Value);
                text = xReader.Value;
            }
            return text;
        }
        static void Main()
        {
            XmlReader xReader = XmlReader.Create(@"C:\Users\Alchemy.DESKTOP-V8A10HM\Documents\SQL\StoredProcedureXML.xml");
            Dictionary<string, List<string>> procedures = new Dictionary<string, List<string>>();
            List<string> names = new List<string>();
            int k = -1;
            while (xReader.Read())
            {
                if (xReader.NodeType == XmlNodeType.Element)
                {
                    switch (xReader.Name)
                    {
                        case "name":
                            //Console.Write("\nProcedure Name: ");
                            k++;
                            names.Add(DisplayText(xReader));
                            procedures[names[k]] = new List<string>();
                            
                            break;

                        case "parameters":
                            //Console.WriteLine("Parameters: ");
                           // if (xReader.IsEmptyElement)
                               // Console.WriteLine("NA");
                            break;


                        case "parametername":
                            //Console.Write("\tParameter Name: ");
                            procedures[names[k]].Add(DisplayText(xReader));
                            //DisplayText(xReader);
                            break;

                        case "parametertype":
                            //Console.Write("\tParameter type: ");
                            procedures[names[k]].Add(DisplayText(xReader));
                            //DisplayText(xReader);
                            break;


                        default:
                            //Console.WriteLine("\n"+xReader.Name);
                            break;
                    };
                    

                }
               
            }
           foreach(KeyValuePair<string,List<string>> items in procedures)
            {
                Console.Write($" Procedure Name : {items.Key}");
                foreach(string item in items.Value)
                {
                    Console.Write($" {item} \t");
                }
                Console.WriteLine();
            }
        }
    }
}
