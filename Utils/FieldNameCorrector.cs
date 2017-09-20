using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace PX.Api.ContractBased.Maintenance.Cli.Utils
{
    public static class FieldNameCorrector
    {
        private static Dictionary<string, string> toReplaceIfMatchWhole = new Dictionary<string, string>
        {
            {  "VendorCustomer","VendorOrCustomer" },
            {  "CustomerVendor","VendorOrCustomer" },
            {  "ExtPrice","ExtendedPrice" },
            {  "ExtCost","ExtendedCost" },
            {  "Currency","CurrencyID" },
        };

        private static Dictionary<string, string> toReplaceIfMatchSegment = new Dictionary<string, string>
        {
            {  "Orig","Original" },
            {  "Amt","Amount" },
            {  "No","Nbr" },
            {  "Number","Nbr" },
            {  "Quantity","Qty" },
            {  "Reference","Ref" },
            {  "Cury","Currency" },
            {  "Curr","Currency" },
            {  "Tran","Transaction" },
            {  "Sub","Subaccount" },
            {  "Beg","Beginning" },
            {  "Descr","Description" },
            {  "Adjg","Adjusting" },
            {  "Adjd","Adjusted" },
            {  "Numberof","NbrOf" },
            {  "Lengthof","LengthOf" },
            {  "Dayof","DayOf" },
        };

        private static Regex SplitByCamel = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z]) | (?<=[^A-Z])(?=[A-Z]) | (?<=[A-Za-z])(?=[^A-Za-z])",
            RegexOptions.IgnorePatternWhitespace | RegexOptions.Compiled);

        public static void CorrectAttributeValue(XAttribute a)
        {
            if (toReplaceIfMatchWhole.ContainsKey(a.Value))
            {
                a.Value = toReplaceIfMatchWhole[a.Value];
                return;
            }

            string[] segments = SplitByCamel.Split(a.Value);

            for (int i = 0; i < segments.Length; ++i)
                if (toReplaceIfMatchSegment.ContainsKey(segments[i]))
                    segments[i] = toReplaceIfMatchSegment[segments[i]];

            a.Value = string.Concat(segments);
        }
    }
}
