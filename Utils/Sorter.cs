using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System;

namespace PX.Api.ContractBased.Maintenance.Cli.Utils
{
    static class Sorter
    {
        public static Action<XAttribute> CorrectFieldName = FieldNameCorrector.CorrectAttributeValue;

        public static void Sort(this XDocument original)
        {
            XElement root = original.Elements().Single();
            XNamespace Namespace = root.Name.Namespace;

            IEnumerable<XElement> Entities = root.Elements().Except(new[] { root.Element(Namespace + "ExtendsEndpoint") }).OrderBy(GetName).ToArray();

            foreach (XElement elt in Entities)
            {
                elt.Element(Namespace + "Fields")?.SortFields();
                elt.Element(Namespace + "Mappings")?.SortMapings();

                elt.Remove();
            }
            root.Add(Entities);
        }

        private static void SortFields(this XElement FieldsElement)
        {
            IEnumerable<XElement> Fields = FieldsElement.Elements().Select(e => 
            {
                CorrectFieldName(GetNameAttr(e));
                return e;
            }).OrderBy(GetName).ToArray();
            foreach (XElement e in Fields) e.Remove();
            FieldsElement.Add(Fields);
        }

        internal static XAttribute GetNameAttr(XElement elt) => elt.Attribute("name");
        internal static string GetName(XElement elt) => GetNameAttr(elt).Value;

        private static void SortMapings(this XElement MappingsElement)
        {
            IEnumerable<XElement> Mappings = MappingsElement.Elements().Select(e =>
            {
                if (e.Name.LocalName == "Mapping") CorrectFieldName(GetFieldAttr(e));
                return e;
            }).OrderBy(GetField).ToArray();

            foreach (XElement e in Mappings)
            {
                SortMapings(e);
                e.Remove();
            }
            MappingsElement.Add(Mappings);
        }

        internal static XAttribute GetFieldAttr(XElement elt) => elt.Attribute("field");
        internal static string GetField(XElement elt) => GetFieldAttr(elt).Value;
    }
}
