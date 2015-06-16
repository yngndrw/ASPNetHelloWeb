using Microsoft.AspNet.Builder;

namespace HelloWeb
{
	public class Startup
	{
		public void Configure(IApplicationBuilder applicationBuilder)
		{
			// Show sample page
			applicationBuilder.UseStaticFiles();
			applicationBuilder.UseWelcomePage();
		}
	}
}
