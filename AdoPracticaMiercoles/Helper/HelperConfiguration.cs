using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdoPracticaMiercoles.Helper
{
    public class HelperConfiguration
    {
        public static IConfiguration GetConfiguration()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true);
            IConfigurationRoot configuration = builder.Build();
            return configuration;
        }
    }
}
