using Microsoft.AspNet.Builder;

namespace HelloWeb
{
	public class Startup
	{
		public void Configure(IApplicationBuilder applicationBuilder)
		{
			applicationBuilder.UseStaticFiles();
			applicationBuilder.UseWelcomePage();
		}
	}
}
