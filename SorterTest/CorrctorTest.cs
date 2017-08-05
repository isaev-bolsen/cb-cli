using Microsoft.VisualStudio.TestTools.UnitTesting;
using PX.Api.ContractBased.Maintenance.Cli.Utils;
using System.Linq;
using System.Xml.Linq;

namespace SorterTest
{
    [TestClass]
    public class CorrctorTest
    {
        [TestMethod]
        public void TestAddingTheCreatedDateTime()
        {
            XDocument Doc = XDocument.Load("Sample1.xml");
            Doc.AddCreatedAndModifiedDateTime();

            foreach (XElement Entity in Doc.Elements().Single().Elements("TopLevelEntity"))
            {
                XElement[] dateTimeFields = Entity.Elements("Field").Where(e => e.Attribute("type").Value == "DateTimeValue").ToArray();
                Assert.IsTrue(dateTimeFields.Length >= 2);
                dateTimeFields.Single(e => e.Attribute("name").Value == "CreatedDateTime");
                dateTimeFields.Single(e => e.Attribute("name").Value == "LastModifiedDateTime");
            }
        }
    }
}
