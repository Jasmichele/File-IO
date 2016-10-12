using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace jwhat
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "C:\\Users\\jasmi\\Documents\\first.txt";

            Numbers n = new Numbers();
            StreamWriter sw = new StreamWriter(fileName, false);

            for (int i = 0; i < 100; i++)
            {
                Numbers n1 = new Numbers();
                sw.WriteLine(string.Format("{0}", i + 1));
            }
            sw.Close();

            StreamReader sr = new StreamReader(fileName);
            List<Numbers> numb = new List<Numbers>();
            if (File.Exists(fileName))
            {
                while (!sr.EndOfStream)
                {
                    string temp = sr.ReadLine();
                    string[] value = temp.Split('\n');

                    Numbers n2 = new Numbers();
                    n2.MyNumber = value[0];

                    numb.Add(n2);
                }
            }
            foreach (Numbers n3 in numb)
            {
                Console.WriteLine("{0}", n3.MyNumber);
            }

            Console.ReadKey();
        }
    }
}
