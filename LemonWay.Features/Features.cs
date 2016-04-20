using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LemonWay
{
    public static class Features
    {
        public static int Fibonacci(int n)
        {
            if (n < 1 || n > 100)
                return -1; //throw new ArgumentException("invalid parameter (must be between 1 and 100)", "n");
            Debug.Assert(n < 47, "A partir du 47ième élément la valeur à retourner (2 971 215 073) ne rentre plus dans un int !" + Environment.NewLine +
                                 "L'énoncé est il mauvais ou est-ce volontaire?");
            decimal acc1 = 1;
            decimal acc2 = 0;
            while (--n > 0)
            {
                decimal tmp = acc1 + acc2;
                acc2 = acc1;
                acc1 = tmp;
            }
            return (int) acc1;
        }

        public static string XmlToJson(string xml)
        {
            XmlDocument doc = new XmlDocument();
            //XDocument doc;
            try
            {
                doc.LoadXml(xml);
                //doc = XDocument.Parse(xml);
            }
            catch
            {
                return "Bad Xml format";
            }

            // TODO : a mettre a un meilleur endroit
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            string jsonText = JsonConvert.SerializeXmlNode(doc.DocumentElement);
            return jsonText;
            
            //var o = ConvertToObject(doc.Elements());
            ////var obj = JsonConvert.SerializeObject<ExpandoObject>(jsonText, new ExpandoObjectConverter());
            //var serializer = new JavaScriptSerializer();
            
            //return serializer.Serialize(obj);
        }
        
        //private static ExpandoObject ConvertToObject(IEnumerable<XElement> properties)
        //{
        //    var o = new ExpandoObject();
        //    var asDico = (IDictionary<String, Object>)o;

        //    foreach (var p in properties)
        //    {
        //        object value = p.HasElements ? ConvertToObject(p.Elements()) : (object)p.Value;
        //        asDico.Add(p.Name.LocalName, value);
        //    }
        //    return o;                
        //}


    }
}
