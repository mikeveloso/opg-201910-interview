using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using opg_201910_interview.Common;
using opg_201910_interview.Models;

namespace opg_201910_interview.Helpers
{
    public static class ClientHelper
    {
        public static List<Client> GetClientFiles(List<ClientXmlFile> xmlFiles)
        {
            List<Client> clients = new List<Client>();

            xmlFiles.ForEach(xmlFile =>
            {
                Client client = new Client() { ClientId = xmlFile.ClientId, ClientName = xmlFile.ClientName };

                List<ClientFile> tempFiles = new List<ClientFile>();
                xmlFile.ClientXmlFiles.ForEach(clientXmlFile => 
                {
                    string filePrefix = string.Empty;
                    string fileNameNoExtension = clientXmlFile.FileName.Replace(clientXmlFile.FileExtension, "");
                    if (ValidationHelper.ValidateFileNameFormat(fileNameNoExtension, xmlFile.ValidFileDateFormat, xmlFile.ValidFilePrefix, xmlFile.FilePrefixSeparator, xmlFile.DateSeparator, out filePrefix))
                    {
                        tempFiles.Add(new ClientFile() { FileName = clientXmlFile.FileName, FileDate = fileNameNoExtension.Replace(clientXmlFile.FileExtension, "").ToDateString(xmlFile.DateSeparator).ToNullableDateTime("yyyy-MM-dd", xmlFile.DateSeparator), FilePreFix = filePrefix });
                    }                    
                });

                client.ClientFiles.AddRange(SortXmlFile(tempFiles, xmlFile.ValidFilePrefix));

                clients.Add(client);
            });

            
            return clients;
        }

        private static List<ClientFile> SortXmlFile(List<ClientFile> xmlFiles, List<string> validPrefixes)
        {
            List<ClientFile> tempFiles = new List<ClientFile>();

            validPrefixes.ForEach(prefix =>
            {
                tempFiles.AddRange(xmlFiles.Where(f => f.FilePreFix.Equals(prefix)).OrderBy(o => o.FileDate));
            });

            return tempFiles;
        }
    }
}
