using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class StringBuilderExtension
    {
        public static StringBuilder AppendLineFormat(this StringBuilder builder, string format, params object[] arguments)
        {
            string value = String.Format(format, arguments);

            builder.AppendLine(value);

            return builder;
        }
    }
}
