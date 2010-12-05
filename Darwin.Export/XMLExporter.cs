using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using Darwin.DataAccess;

namespace Darwin.Export
{
    public class XMLExporter
    {
        public static void ExportToMindMap(string filename)
        {
            XmlDocument XD = new XmlDocument();
            XmlElement root = XD.CreateElement("map");
            root.SetAttribute("version", "0.9.0");

            XmlElement nm = XD.CreateElement("node");

            IEnumerable<KingdomDataGrid> k = KingdomDataAccess.GetAllKingdoms();
            foreach (KingdomDataGrid item in k)
            {
                XmlElement e = XD.CreateElement("node");
                e.SetAttribute("STYLE", "bubble");
                e.SetAttribute("TEXT", item.KingdomName);

                IEnumerable<PhylumDataGrid> p = PhylumDataAccess.GetPhylumsByKingdom(item.KingdomId);

                foreach (var pitem in p)
                {
                    XmlElement e2 = XD.CreateElement("node");
                    e2.SetAttribute("STYLE", "bubble");
                    e2.SetAttribute("TEXT", pitem.PhylumName);


                    IEnumerable<ClassDataGrid> c = ClassDataAccess.GetClasssByPhylum(pitem.PhylumId);

                    foreach (var citem in c)
                    {
                        XmlElement e3 = XD.CreateElement("node");
                        e3.SetAttribute("STYLE", "bubble");
                        e3.SetAttribute("TEXT", citem.ClassName);


                        IEnumerable<OrderDataGrid> o = OrderDataAccess.GetOrdersByClass(citem.ClassId);

                        foreach (var oitem in o)
                        {
                            XmlElement e4 = XD.CreateElement("node");
                            e4.SetAttribute("STYLE", "bubble");
                            e4.SetAttribute("TEXT", oitem.OrderName);


                            IEnumerable<FamilyDataGrid> f = FamilyDataAccess.GetFamiliesByOrder(oitem.OrderId);

                            foreach (var fitem in f)
                            {
                                XmlElement e5 = XD.CreateElement("node");
                                e5.SetAttribute("STYLE", "bubble");
                                e5.SetAttribute("TEXT", fitem.FamilyName);


                                IEnumerable<GenusDataGrid> g = GenusDataAccess.GetGenusByFamily(fitem.FamilyId);

                                foreach (var gitem in g)
                                {
                                    XmlElement e6 = XD.CreateElement("node");
                                    e6.SetAttribute("STYLE", "bubble");
                                    e6.SetAttribute("TEXT", gitem.GenusName);


                                    IEnumerable<SpeciesData> s = SpeciesDataAccess.GetSpeciesByGenus(gitem.GenusId);

                                    foreach (var sitem in s)
                                    {
                                        XmlElement e7 = XD.CreateElement("node");
                                        e7.SetAttribute("STYLE", "bubble");
                                        e7.SetAttribute("TEXT", sitem.SpeciesName);


                                        e6.AppendChild(e7);
                                    }


                                    e5.AppendChild(e6);
                                }



                                e4.AppendChild(e5);
                            }


                            e3.AppendChild(e4);
                        }


                        e2.AppendChild(e3);
                    }

                    e.AppendChild(e2);
                }

                nm.AppendChild(e);
            }

            nm.SetAttribute("TEXT", "Darwin");



            root.AppendChild(nm);

            XD.AppendChild(root);
            XD.Save(filename);

        }


    }
}
