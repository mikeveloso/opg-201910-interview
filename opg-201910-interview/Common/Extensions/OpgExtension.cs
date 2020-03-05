using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace opg_201910_interview.Common
{
    public static class OpgExtension
    {
        public static string ToDateString(this string str, string dateSeparator)
        {
            string regEx = string.Concat("[^0-9", dateSeparator, "]+");
            string tempDate = Regex.Replace(str, regEx, "", RegexOptions.Compiled);
            return Regex.IsMatch(tempDate, @"^\d") ? tempDate : tempDate.Substring(1, tempDate.Length - 1);
        }

        public static bool IsValidStringDate(this string str, string validDateFormat)
        {
            try
            {
                DateTime? date = DateTime.ParseExact(str, validDateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);

                return date.HasValue;                
            }
            catch
            {
                return false;
            }
        }

        public static DateTime? ToNullableDateTime(this string str, string validDateFormat, string dateSeparator)
        {
            try
            {
                DateTime? date = DateTime.ParseExact(str.ToDateString(dateSeparator), validDateFormat, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.None);

                return date.HasValue ? date : null;
            }
            catch
            {
                return null;
            }
        }

        public static string FilePrefix(this string str, string separator)
        {
            string regEx = string.Concat("[^a-zA-Z0-9", separator, "]+");
            string fileName = Regex.Replace(str, regEx, "", RegexOptions.Compiled);
            string[] filePrefixes = fileName.Split(separator);

            return (filePrefixes.Length > 0 ? filePrefixes[0] : fileName);
        }
    }
}
