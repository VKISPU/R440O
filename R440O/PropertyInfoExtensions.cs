using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace R440O
{
    public static class PropertyInfoExtensions
    {
        public static object GetValue(this System.Reflection.PropertyInfo prop, object obj)
        {
            return prop.GetValue(obj, null);
        }

        public static void SetValue(this System.Reflection.PropertyInfo prop, object obj, object newValue)
        {
            prop.SetValue(obj, newValue, null);
        }
    }
}
