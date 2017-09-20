using Microsoft.VisualStudio.TestTools.UnitTesting;
using PX.Api.ContractBased.Maintenance.Cli.Utils;
using System.Collections.Generic;
using System.Xml.Linq;

namespace SorterTest
{
    [TestClass]
    public class FieldNameCorrectorTest
    {
        private Dictionary<string, string> DataDictionary = new Dictionary<string, string>
        {
            { "OrigOrderNbr", "OriginalOrderNbr" },
            { "VendorCustomer", "VendorOrCustomer" },
            { "CustomerVendor",  "VendorOrCustomer" },
            { "CardAccountNo",  "CardAccountNbr" }
        };

        [TestMethod]
        public void TestOriginal()
        {
            foreach (var pair in DataDictionary)
            {
                XAttribute attr = new XAttribute("field", pair.Key);
                FieldNameCorrector.CorrectAttributeValue(attr);
                Assert.AreEqual(pair.Value, attr.Value);
            }
        }
    }
}
