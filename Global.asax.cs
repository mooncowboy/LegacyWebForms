using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LegacyWebForms
{
    public class Global
    {
        public static void ConfigureApplication(WebApplication app)
        {
            // Register routes
            RouteConfig.RegisterRoutes(app);

            // Register bundles (static files)
            BundleConfig.RegisterBundles(app);
        }
    }
}