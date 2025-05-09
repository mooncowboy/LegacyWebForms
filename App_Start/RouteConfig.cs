using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LegacyWebForms
{
    public class RouteConfig
    {
        public static void RegisterRoutes(WebApplication app)
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // Define your routes here
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                // Example: Map static files or other custom routes if needed
                endpoints.MapFallbackToFile("index.html");
            });
        }
    }
}
