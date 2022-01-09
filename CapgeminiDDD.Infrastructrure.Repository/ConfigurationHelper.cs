using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace CapgeminiDDD.Infrastructure.Repository
{
    internal class ConfigurationHelper
    {
        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            return config;
        }
    }
}