using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

using opg_201910_interview.Common;

namespace opg_201910_interview.Helpers
{    
    public class ValidationHelper
    {        
        public static bool ValidateFileNameFormat(string fileNameNoExtension, string validDateFormat, List<string> validFilePrefix, string filePrefixSeparator, string dateSeparator, out string filePrefix)
        {
            string regEx = string.Concat("[^a-zA-Z0-9", dateSeparator, filePrefixSeparator, "]+");
            string fileName = Regex.Replace(fileNameNoExtension, regEx, "", RegexOptions.Compiled);
            string prefix = fileNameNoExtension.FilePrefix(filePrefixSeparator);

            filePrefix = validFilePrefix.Where(p => p.Equals(prefix)).FirstOrDefault();
            string filePrefixWithSeparator = string.Concat(filePrefix, filePrefixSeparator);
            string fileDate = fileName.Replace(filePrefixWithSeparator, "");

            bool isValid = (!string.IsNullOrEmpty(filePrefix) && fileDate.IsValidStringDate(validDateFormat));

            return isValid;
        }
    }
}
