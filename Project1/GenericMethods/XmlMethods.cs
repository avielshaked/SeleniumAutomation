using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Project1.GenericMethods
{
    public class XmlMethods : Generic_Methods
    {
        #region Fields
        protected string absolutePath = ConfigurationManager.AppSettings["TddPath"].ToString();
        protected string requiredPath;

        #endregion

        public string[] GetXmlData(string tagname)
        {
            requiredPath = Get_Relative_Project_Path();

            //Create the XmlDocument.
            XmlDocument doc = new XmlDocument();
            doc.Load(requiredPath + absolutePath);

            //Display all the book titles.
            XmlNodeList elemList = doc.GetElementsByTagName(tagname);
            string[] arr = new string[elemList.Count];
            for(int i=0; i<elemList.Count; i++)
            {
                arr[i] = elemList[i].InnerXml;
            }
            return arr;
        }

        public string GetXmlOneValue(string tagname)
        {
            requiredPath = Get_Relative_Project_Path();

            using(XmlReader reader = XmlReader.Create(requiredPath + absolutePath))
            {
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        if (reader.Name.ToString().Equals(tagname))
                            return reader.ReadString();
                    }
                }
            }
            return "NULL";
        }

    }
}
