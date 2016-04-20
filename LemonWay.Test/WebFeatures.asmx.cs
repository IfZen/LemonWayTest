using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace LemonWay.Test
{
    /// <summary>
    /// Summary description for WebFeatures
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebFeatures : System.Web.Services.WebService
    {

        [WebMethod]
        public int Fibonacci(int n)
        {
            return Features.Fibonacci(n);
        }

        [WebMethod]
        public string XmlToJson(string xml)
        {
            return Features.XmlToJson(xml);
        }

    }
}
