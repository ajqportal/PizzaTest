using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace PizzaTest.Helpers
{
    public static class ConfigurationHelper
    {
        public static string GetFileFullPath()
        {
            var config =  new ConfigurationBuilder().AddJsonFile("appSettings.json").Build();
            return config.GetSection("filePath").Value;
        }
    }
}
