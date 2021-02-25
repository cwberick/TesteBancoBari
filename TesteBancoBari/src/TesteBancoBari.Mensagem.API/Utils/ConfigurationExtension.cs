using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteBancoBari.Mensagem.API.Utils
{
    public static class ConfigurationExtensions
    {
        public static string GetMessageQueueConnection(this IConfiguration configuration)
        {
            return configuration?.GetSection("MessageQueueConnection")?.Value;
        }
    }
}
