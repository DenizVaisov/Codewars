using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TwoToOne
{
    public class TwoToOne
    {
        public static string Longest (string s1, string s2)
        {
            string[] strArray = {s1, s2};
//            IEnumerable<string> words = strArray.OrderBy(y => s1.Count()).ThenBy(z => s2.Count());
//            IEnumerable<string> words = strArray.Where(z => z.Length == (strArray.Max(n => n.Length))).Max().Distinct();
            Array.Sort(strArray, (x,y) => String.CompareOrdinal(s1, s2));
            
            return null;
        }
    }
}