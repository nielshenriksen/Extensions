using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class Int32Extension
    {
        public static string PadZero(this int sValue, int iMaxLength)
        {
            var fmt = new String('0', iMaxLength) + ".##";
            string formatString = "{0," + iMaxLength + ":" + fmt + "}";

            return String.Format(formatString, sValue);
        }
    }
}
