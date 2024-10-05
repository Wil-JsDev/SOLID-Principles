using Microsoft.EntityFrameworkCore;
using SOLID.SRP.Context;

namespace SOLID.SRP
{
    public static class AddSRP 
    {
        public static void AddContextSRP(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SRPContext>(p =>
            {
                p.UseSqlServer(configuration.GetConnectionString("SOLID"));
            });

        }
    }
}
