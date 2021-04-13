using Furion;
using Furion.DatabaseAccessor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Configuration;

namespace detectingsystem.EntityFramework.Core
{
    public class Startup : AppStartup
    {
        private  Configuration Configuration { get; }

        public Startup() { }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseAccessor(options =>
            {
                options.AddDbPool<DefaultDbContext>(DbProvider.SqlServer, connectionString: "");

            });
        }
    } }