using System.Linq;
using System.Xml.Linq;
using System.Collections.Generic;
using System;

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
                elt.Element(Namespace + "Mappings")?.AddMapings();
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

        private static void AddMapings(this XElement MappingsElement)
        {
            IEnumerable<XElement> mapingsToObjects = MappingsElement.Elements("Mapping").Where(e => e.Elements("To").Count() > 0);

            Lazy<string> objectToMap = new Lazy<string>(() =>
            mapingsToObjects.Select(e => e.Element("To").Attribute("object")).GroupBy(a => a.Value).OrderByDescending(g => g.Count()).First().Key);

            foreach (string fieldName in mandatoryDateTimeFields)
            {
                XElement fieldMapping = mapingsToObjects.SingleOrDefault(e => e.Attribute("field").Value == fieldName);
                if (fieldMapping == null)
                {
                    MappingsElement.Add(new XElement(
                        "Mapping",
                        new XAttribute("field", fieldName),
                        new XElement("To", new XAttribute("object", objectToMap), new XAttribute("field", fieldName))
                        ));
                }
            }
        }
    }
}