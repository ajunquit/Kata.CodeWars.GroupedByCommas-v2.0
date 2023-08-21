using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.CodeWars.GroupedByCommas_v2._0
{
    public static class Kata
    {
        public static string GroupByCommas(int n)
        {
            return String.Format("{0:n0}", n);
        }
    }
}
