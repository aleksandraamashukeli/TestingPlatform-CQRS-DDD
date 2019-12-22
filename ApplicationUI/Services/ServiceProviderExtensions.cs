using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer;
using Microsoft.EntityFrameworkCore;

namespace ApplicationUI.Services
{
    public static class ServiceProviderExtensions
    {
        public static void AddDataAccessService(this IServiceCollection services,string connectionString)
        {
            services.AddDbContext<DatabaseContext>(db =>
            {
                db.UseSqlServer(connectionString);
            });
        }
    }
}
