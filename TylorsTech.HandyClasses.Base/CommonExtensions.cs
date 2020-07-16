using System;
using System.Collections.Generic;
using System.Text;

namespace TylorsTech.HandyClasses.Base.Extensions
{
    public static class CommonExtensions
    {
        public static bool IsNullOrEmpty(this string str) => string.IsNullOrEmpty(str);
        public static bool IsNullOrWhitespace(this string str) => string.IsNullOrWhiteSpace(str);

        public static int ToInt(this string str) => int.Parse(str);
        public static int ToInt(this string str, int defaultValue = default) => int.TryParse(str, out int i) ? i : defaultValue;

        public static double ToDouble(this string str) => double.Parse(str);
        public static double ToDouble(this string str, double defaultValue = default) => double.TryParse(str, out double i) ? i : defaultValue;

        public static bool ToBool(this string str) => bool.Parse(str);
        public static bool ToBool(this string str, bool defaultValue = default) => bool.TryParse(str, out bool i) ? i : defaultValue;

        public static string ToHex(this int i) => $"0x{i:X}";
    }
}
