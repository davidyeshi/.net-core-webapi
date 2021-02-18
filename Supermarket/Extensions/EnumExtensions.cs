using Microsoft.AspNetCore.Mvc.Routing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Supermarket.Extensions
{
    public static class EnumExtensions
    {
        // Generic method that can receive more than one type of argument
        // in this case, represented by the TEnum declaration
        // Since enum is a reserved keyword in C#, we added an @ in front of the parameter's
        // name to make it a valid name
        public static string ToDescriptionString<TEnum>(this TEnum @enum)
        {
            FieldInfo info = @enum.GetType().GetField(@enum.ToString());
            var attributes = (DescriptionAttribute[])info.GetCustomAttributes(typeof(DescriptionAttribute), false);

            return attributes?[0].Description ?? @enum.ToString();
        }
    }
}
