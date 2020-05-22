using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || args.Contains("-help") || args.Contains("-?"))
            {
                Console.WriteLine("usage: " +
                    "a.exe [-?] [-e encoding] [-sep separator] -fin filenameIn -fout filenameOut");
                return;
            }

            string enc = "utf-8";
            char sep = ';';
            string filenameIn = null;
            string filenameOut = null;

            for (int i = 0; i < args.Length; i++)
            {
                switch (args[i].ToLower())
                {
                    case "-e":
                        enc = args[++i];
                        break;
                    case "-sep":
                        sep = args[++i][0];
                        break;
                    case "-fin":
                        filenameIn = args[++i];
                        break;
                    case "-fout":
                        filenameOut = args[++i];
                        break;
                    default:
                        Console.WriteLine("invalid argument: " + args[i]);
                        return;
                }
            }

            if (filenameIn == null)
            {
                Console.WriteLine("please specify input file name with -fin");
                return;
            }

            if (filenameOut == null)
            {
                Console.WriteLine("please specify output file name with -fout");
                return;
            }

            XmlDocument doc = new XmlDocument();

            XmlElement table = doc.CreateElement("table");
            using (StreamReader reader = new StreamReader(filenameIn, Encoding.GetEncoding(enc)))
            {
                int i = 0;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] p = line.Split(sep);
                    XmlElement r = doc.CreateElement("row");
                    r.SetAttribute("i", (++i).ToString());
                    for (int j = 0; j < p.Length; j++)
                    {
                        XmlElement c = doc.CreateElement("col");
                        c.SetAttribute("j", (j + 1).ToString());
                        c.AppendChild(doc.CreateTextNode(p[j]));
                        r.AppendChild(c);
                    }
                    table.AppendChild(r);
                }
            }

            doc.AppendChild(table);
            using (StreamWriter writer = new StreamWriter(filenameOut, false, Encoding.UTF8))
            {
                doc.Save(writer);
            }

            Console.WriteLine("done");
        }
    }
}
