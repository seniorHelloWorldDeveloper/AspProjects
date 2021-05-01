using System;
using System.Linq;
using System.Reflection;
using DatabaseDevelopment.Attributes;

namespace DatabaseDevelopment.Helpers
{
    public static class AttrubteHelpers
    {
        public static bool HasAttribute(this MethodInfo info, Type attribute) {
            return info.GetCustomAttributes(attribute, false).Length > 0;
        }
    }
}