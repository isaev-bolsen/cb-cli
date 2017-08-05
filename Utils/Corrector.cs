using System.Linq;
using System.Xml.Linq;

namespace PX.Api.ContractBased.Maintenance.Cli.Utils
{
    public static class Corrector
    {
        private static string[] mandatoryDateTimeFields = new[] { "CreatedDateTime", "LastModifiedDateTime" };

        public static void AddCreatedAndModifiedDateTime(this XDocument original)
        {
            XElement root = original.Elements().Single();
            XNamespace Namespace = root.Name.Namespace;

            foreach (XElement elt in root.Elements("TopLevelEntity"))
            {
                elt.Element(Namespace + "Fields").AddFields();
                //elt.Element(Namespace + "Mappings")?.SortMapings();
            }
        }

        private static void AddFields(this XElement FieldsElement)
        {
            foreach (string fieldName in mandatoryDateTimeFields)
            {
                XElement fieldDefinition = FieldsElement.Elements("Field").SingleOrDefault(e => e.Attribute("name").Value == fieldName);
                if (fieldDefinition == null)
                {
                    FieldsElement.Add(new XElement(
                        "Field", 
                        new XAttribute("name", fieldName), 
                        new XAttribute("type", "DateTimeValue")
                        ));
                }
            }
        }
    }
}
