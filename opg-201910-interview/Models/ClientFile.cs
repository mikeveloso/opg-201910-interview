using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace opg_201910_interview.Models
{
    public class ClientFile
    {
        public string FilePreFix { get; set; }

        public string FileName { get; set; }

        public DateTime? FileDate { get; set; }

        public override bool Equals(object obj)
        {
            var clientFile = (ClientFile)obj;
            return this.FilePreFix == clientFile.FilePreFix && this.FileName == clientFile.FileName && this.FileDate == clientFile.FileDate;
        }
    }
}
