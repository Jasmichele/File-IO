using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XL
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Plant> myPlant = new List<Plant>();

            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\jasmi\\Downloads\\plant_catalog.xml");

            XmlNode catNode = doc.DocumentElement.SelectSingleNode("/CATALOG");

            foreach (XmlNode child in catNode.ChildNodes)
            {
                Plant plant = new Plant();
                foreach (XmlNode grandchild in child.ChildNodes)
                {
                    switch (grandchild.Name)
                    {
                        case "COMMON":
                            {
                                plant.COMMON = grandchild.InnerText;
                                break;
                            }
                        case "BOTANICAL":
                            {
                                plant.BOTANICAL = grandchild.InnerText;
                                break;
                            }
                        case "ZONE":
                            {
                                plant.ZONE = grandchild.InnerText;
                                break;
                            }
                        case "LICHT":
                            {
                                plant.LIGHT = grandchild.InnerText;
                                break;
                            }
                        case "PRICE":
                            {
                                plant.PRICE = grandchild.InnerText;
                                break;
                            }
                        case "AVAILABILTY":
                            {
                                plant.AVAILABILTY = Convert.ToDateTime(grandchild.InnerText);
                                break;
                            }

                        default:
                            {
                                break;
                            }
                    }
                }

                myPlant.Add(plant);
            }

          


            foreach (Plant p in myPlant)
            {

                Console.WriteLine(string.Format("Common {0}", p.COMMON));
                Console.WriteLine("___________________");
                Console.WriteLine(string.Format("Botanical {0}", p.BOTANICAL));
                Console.WriteLine(string.Format("Zone {0}", p.ZONE));
                Console.WriteLine(string.Format("Light {0}", p.LIGHT));
                Console.WriteLine(string.Format("Price {0}", p.PRICE));
                Console.WriteLine(string.Format("Availabilty {0}", p.AVAILABILTY));
                Console.WriteLine();


            }


            Console.ReadKey();
        }


    }

}
