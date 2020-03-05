using System;
using System.Collections.Generic;

namespace opg_201910_interview.Models
{
    public class ClientSettings
    {
        public ClientSettings()
        {
            clientSettings = new List<ClientSetting>();
        }

        public List<ClientSetting> clientSettings { get; set; }
    }

    public class ClientSetting
    {
        public int ClientId { get; set; }

        public string FileDirectoryPath { get; set; }
    }
}
