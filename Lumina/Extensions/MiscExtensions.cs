using System;
using System.Linq;
using System.Reflection;

namespace Lumina.Extensions
{
    public static class MiscExtensions
    {
        public static TAttribute GetAttribute< TAttribute >( this Enum enumValue )
            where TAttribute : Attribute
        {
            return enumValue
                .GetType()
                .GetMember( enumValue.ToString() )
                .First()
                .GetCustomAttribute< TAttribute >();
        }
    }
}