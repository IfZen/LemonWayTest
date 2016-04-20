using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonWay.FeaturesTests2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FibonacciTest1()
        {
            Assert.Equals(Features.Fibonacci(1), 1);
        }

        [TestMethod]
        public void FibonacciTest2()
        {
            Assert.Equals(Features.Fibonacci(4), 5);
        }

        [TestMethod]
        public void XmlToJSonTest1()
        {
            Assert.AreEqual("{\"foo\":\"bar\"}", Features.XmlToJson("<foo>bar</foo>"));
        }

        public void XmlToJSonTest2()
        {
            var xml2 = "<TRANS><HPAY><ID>103</ID><STATUS>3</STATUS><EXTRA><IS3DS>0</IS3DS><AUTH>031183</AUTH></EXTRA><INT_MSG/><MLABEL>501767XXXXXX6700</MLABEL><MTOKEN>project01</MTOKEN></HPAY></TRANS>";
            var res2 = "{\"TRANS\":{\"HPAY\":{\"ID\":\"103\",\"STATUS\":\"3\",\"EXTRA\":{\"IS3DS\":\"0\",\"AUTH\":\"031183\"},\"INT_MSG\":null,\"MLABEL\":\"501767XXXXXX6700\",\"MTOKEN\":\"project01\"}}}";
            Assert.AreEqual(res2, Features.XmlToJson(xml2));
        }
    }
}
