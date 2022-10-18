using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeBits.Shared
{
    public static class StringExtension
    {
        public static string Trucate(this string str, int maxLength)
        {
            if (string.IsNullOrEmpty(str)) return str;
            return str.Substring(0, Math.Min(str.Length, maxLength));
        }
    }
}
