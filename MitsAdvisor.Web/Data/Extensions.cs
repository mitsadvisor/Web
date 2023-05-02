namespace MitsAdvisor.Web.Data
{
	public static class Extensions
	{
		public static void CreateDbIfNotExists(this IHost host)
		{
			using (var scope = host.Services.CreateScope())
			{
				var services = scope.ServiceProvider;
				var dbContext = services.GetRequiredService<MitsadvisorContext>();
				dbContext.Database.EnsureCreated();
				DbInitializer.Initialize(dbContext);
			}
		}
	}
}
