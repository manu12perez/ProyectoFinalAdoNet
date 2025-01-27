using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace ProyectoFinalAdoNet.Helpers
{
    public class HelperConfig
    {
            public static string GetStringConnection()
            {
                ConfigurationBuilder builder = new ConfigurationBuilder();

                builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true);

                IConfigurationRoot configurationRoot = builder.Build();

                return configurationRoot.GetConnectionString("SqlTajamar");
            }
        
    }
}
