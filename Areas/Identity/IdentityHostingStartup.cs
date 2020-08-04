using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(VintageStuff.Areas.Identity.IdentityHostingStartup))]
namespace VintageStuff.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}