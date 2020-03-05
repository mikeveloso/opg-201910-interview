using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Extensions.Configuration;
using opg_201910_interview.Models;

namespace opg_201910_interview
{
    public class ConfigurationHelper : ConfigurationBase
    {
        private static string AppSettingFile
        {
            get
            {
                string applicationSettingJsonFile = "appsettings.json";

                if (OpgHostEnvironment.IsDevelopment)
                {
                    applicationSettingJsonFile = "appsettings.Development.json";
                }

                return applicationSettingJsonFile;
            }
        }

        private static IConfigurationRoot AppSettings
        {
            get
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile(AppSettingFile)
                .Build();

                return configuration;
            }
        }

        public static string GetConfiguration(string sectionkey, string key)
        {
            string sectionKey = string.Format("{0}:{1}", sectionkey, key);

            string sectionValue = string.Empty;

            var section = AppSettings.GetSection(sectionKey);

            if (section != null)
            {
                sectionValue = section.Value;
            }

            return sectionValue;
        }

        public static List<ClientSetting> GetClientSettings() => AppSettings.Get<ClientSettings>().clientSettings;        
    }
}
