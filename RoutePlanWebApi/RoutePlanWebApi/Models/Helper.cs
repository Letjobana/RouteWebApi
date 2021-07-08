using System;
using System.Collections.Generic;
using System.Linq;

namespace RoutePlanWebApi.Models
{
    public class Helper
    {
        public static List<string> GetListFromCommaSeparatedString(string items)
        {
            string[] strArray = new string[0];
            if (items != null)
                strArray = items.Split(new string[1] { "," }, StringSplitOptions.RemoveEmptyEntries);
            return ((IEnumerable<string>)strArray).Select<string, string>((Func<string, string>)(i => i)).ToList<string>();
        }
    }
}
