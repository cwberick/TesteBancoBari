using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteBancoBari.Mensagem.API.Application;

namespace TesteBancoBari.Mensagem.API.Configuration
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<MensagemServices>();

        }
    }
}
