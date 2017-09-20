using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System;
using System.Text.RegularExpressions;

namespace PX.Api.ContractBased.Maintenance.Cli.Utils
{
    public static class FieldNameCorrector
    {
        private static Regex SplitByCamel = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z]) | (?<=[^A-Z])(?=[A-Z]) | (?<=[A-Za-z])(?=[^A-Za-z])",
            RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);
        
        public static void CorrectAttributeValue(XAttribute a)
        {
            string[] segments = SplitByCamel.Split(a.Value);

            if (segments[0] == "Orig") segments[0] = "Original";

            a.Value = string.Concat(segments);
        }
    }
}
