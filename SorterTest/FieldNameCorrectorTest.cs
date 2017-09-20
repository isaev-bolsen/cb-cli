using Microsoft.VisualStudio.TestTools.UnitTesting;
using PX.Api.ContractBased.Maintenance.Cli.Utils;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SorterTest
{
    [TestClass]
    public class FieldNameCorrectorTest
    {
        private static XAttribute GetAttribute(string value) => new XAttribute("field", value);

        [TestMethod]
        public void TestOriginal()
        {
            XAttribute attr = GetAttribute("OrigOrderNbr");
            FieldNameCorrector.CorrectAttributeValue(attr);
            Assert.AreEqual("OriginalOrderNbr", attr.Value);
        }
    }
}
