using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using System.Xml;
using System.IO;

namespace Read_Infopth_Doc
{
    class ReadSP
    {
        public static void readSPFIle (string url = "http://<Your SHarepoint site URL.com", string list ="your form library name")
        {
            //Open SharePoint site 
            using (SPSite site = new SPSite(url))
            {
                using (SPWeb web = site.OpenWeb())
                {
                    //Get forms library 
                    SPList formsLib = web.Lists[list];
                    if (formsLib != null)
                    {
                        int c = 0;
                        foreach (SPListItem item in formsLib.Items)
                        {
                            XmlDocument xml = new XmlDocument();
                            //Open XML file and load it into XML document 
                            using (Stream s = item.File.OpenBinaryStream())
                            {
                                xml.Load(s);
                            }
                            Console.WriteLine(c + "=>" + item.Title.ToString());
                            c++;
                            //Do your stuff with xml here. This is just an example of setting a boolean field to false. 
                            /*XmlNodeList nodes = xml.GetElementsByTagName("my:enter");
                            foreach (XmlNode node in nodes)
                            {
                                //node.InnerText = "i have set this new field";

                                Console.WriteLine(node.InnerText.ToString());
                                c++;
                            }
                            */

                            //Get binary data for new XML
                            /*
                            byte[] xmlData = System.Text.Encoding.UTF8.GetBytes(xml.OuterXml);
                            using (MemoryStream ms = new MemoryStream(xmlData))
                            {
                                //Write data to SharePoint XML file 
                                //item.File.SaveBinary(ms);
                            }
                            */
                        }
                    }
                }
            }
        }
    }
}
