using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opg_201910_interview.Models
{
    public class ClientXmlFile
    {
        public ClientXmlFile()
        {
            ClientXmlFiles = new List<UploadedXmlFile>();
        }

        public int ClientId { get; set; }

        public string ClientName { get; set; }

        public string XmlFilePath { get; set; }

        public List<string> ValidFilePrefix { get; set; }

        public string FilePrefixSeparator { get; set; }

        public string ValidFileDateFormat { get; set; }

        public string DateSeparator { get; set; }

        public List<UploadedXmlFile> ClientXmlFiles { get; set; }

        public override bool Equals(object obj)
        {
            return this == ((ClientXmlFile)obj);
        }
    }

    public class UploadedXmlFile
    {
        public string FileName { get; set; }

        public string FileExtension { get; set; }

        public override bool Equals(object obj)
        {
            return this == ((UploadedXmlFile)obj);
        }
    }
}
