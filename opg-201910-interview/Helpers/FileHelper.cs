
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using opg_201910_interview.Models;

namespace opg_201910_interview.Helpers
{
    public class FileHelper
    {
        private static List<string> ClientFilePrefix(int clientId)
        {
            List<string> filePrefixes = new List<string>();

            if (clientId == 1001)
            {
                filePrefixes = new List<string>() { "shovel", "waghor", "blaze", "discus" };
            }
            else if (clientId == 2001)
            {
                filePrefixes = new List<string>() { "orca", "widget", "eclair", "talon" };
            }

            return filePrefixes;
        }

        private static string ClientValidFileDateFormat(int clientId)
        {
            if (clientId == 1001)
            {
                return "yyyy-MM-dd";

            }
            else if (clientId == 2001)
            {
                return "yyyyMMdd";
            }

            return string.Empty;
        }

        private static string ClientFileSeparator(int clientId)
        {
            if (clientId == 1001)
            {
                return "-";

            }
            else if (clientId == 2001)
            {
                return "_";
            }

            return string.Empty;
        }

        private static string ClientFileDateSeparator(int clientId)
        {
            if (clientId == 1001)
            {
                return "-";

            }

            return string.Empty;
        }

        public static List<ClientXmlFile> GetClientXmlFiles()
        {
            List<ClientXmlFile> clientFiles = new List<ClientXmlFile>();
            List<ClientSetting> clientSettings = ConfigurationHelper.GetClientSettings();

            clientSettings.ForEach(clientSetting =>
            {
                List<string> fileContents = OpgHostEnvironment.HostEnvironment.ContentRootFileProvider.GetDirectoryContents(clientSetting.FileDirectoryPath)
                .Where(i => i.IsDirectory.Equals(false))
                .Select(i => i.PhysicalPath).ToList();

                ClientXmlFile clientXmlFile = new ClientXmlFile();
                
                fileContents.ForEach(fileContent =>
                {
                    FileInfo fileInfo = new FileInfo(fileContent);

                    clientXmlFile.ClientId = clientSetting.ClientId;
                    clientXmlFile.ClientName = fileInfo.Directory.Name;
                    clientXmlFile.XmlFilePath = fileInfo.Directory.FullName;
                    clientXmlFile.ValidFilePrefix = ClientFilePrefix(clientSetting.ClientId);
                    clientXmlFile.FilePrefixSeparator = ClientFileSeparator(clientSetting.ClientId);
                    clientXmlFile.ValidFileDateFormat = ClientValidFileDateFormat(clientSetting.ClientId);
                    clientXmlFile.DateSeparator = ClientFileDateSeparator(clientSetting.ClientId);
                    clientXmlFile.ClientXmlFiles.Add(new UploadedXmlFile() { FileName = fileInfo.Name, FileExtension = fileInfo.Extension });
                });

                clientFiles.Add(clientXmlFile);
            });

            return clientFiles;
        }
    }
}
