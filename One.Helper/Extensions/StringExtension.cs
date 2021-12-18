using System;

namespace One.Helper.Extensions
{
    public static class StringExtension
    {
        /// <summary>
        /// Parses the text to specified enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumText"></param>
        /// <returns></returns>
        public static T? ParseEnum<T>(this string enumText) where T : struct
        {
            if (Enum.TryParse(enumText, true, out T parsedEnum))
            {
                return parsedEnum;
            }

            return null;
        }

        /// <summary>
        /// Parses the text to specified enum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumText"></param>
        /// <param name="defaultValue">Default value used if parsing fails</param>
        /// <returns></returns>
        public static T ParseEnum<T>(this string enumText, T defaultValue) where T : struct
        {
            var enumValue = ParseEnum<T>(enumText);
            return enumValue ?? defaultValue;
        }
    }
}
