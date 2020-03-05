using System;
using System.IO;
using System.Linq;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace opg_201910_interview
{
    public static class OpgHostEnvironment
    {
        public static IWebHostEnvironment HostEnvironment;

        public static void Configure(IWebHostEnvironment env)
        {
            HostEnvironment = env;
        }

        public static string Environment => HostEnvironment.EnvironmentName;

        public static bool IsDevelopment => HostEnvironment.IsDevelopment();

        public static string ClientSettings => "ClientSettings";

        public static string WebRootPath => HostEnvironment.WebRootPath;

        public static string ResolvePhysicalPath(string path) 
        {
            var contents = HostEnvironment.ContentRootFileProvider.GetDirectoryContents(path).Select(c => c.PhysicalPath).FirstOrDefault();

            FileInfo fileInfo = new FileInfo(contents);
            return fileInfo.Directory.FullName;             
        } 
    }
}
