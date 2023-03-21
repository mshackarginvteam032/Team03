using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using PartsUnlimitedApi.Models;


namespace PartsUnlimitedApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void Configure(IApplicationBuilder app)
        {
            var i = 1;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<PartsUnlimitedContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("PartsUnlimitedDb")));
        }
    }
}
