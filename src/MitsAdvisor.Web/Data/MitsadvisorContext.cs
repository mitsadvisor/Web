using Microsoft.EntityFrameworkCore;
using MitsAdvisor.Web.Models;
using System.Data.Common;

namespace MitsAdvisor.Web.Data
{
	public class MitsadvisorContext:DbContext
	{
		protected readonly IConfiguration Configuration;

        public MitsadvisorContext(IConfiguration configuration)
        {
                Configuration = configuration;
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// connect to postgres with connection string from app settings
			optionsBuilder.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
		}

		public DbSet<Restaurant> Restaurants=> Set<Restaurant>();
		public DbSet<Menu> Menus => Set<Menu>();
		public DbSet<MenuItem> MenuItems => Set<MenuItem>();
	}
}
