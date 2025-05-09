using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LegacyWebForms
{
    public class RouteConfig
    {
        public static void RegisterRoutes(WebApplication app)
        {
            app.UseRouting();

            // Move route registrations to top-level
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapFallbackToFile("index.html");
        }
    }
}
