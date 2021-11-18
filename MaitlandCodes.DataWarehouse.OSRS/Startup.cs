using Hangfire;
using MAD.Integration.Common.Settings;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

namespace MaitlandCodes.DataWarehouse.OSRS
{
    internal class Startup
    {
        public void ConfigureServices(IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddIntegrationSettings<AppConfig>();
        }

        public void Configure()
        {

        }
    }
}