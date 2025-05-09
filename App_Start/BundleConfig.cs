using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LegacyWebForms
{
    public class BundleConfig
    {
        public static void RegisterBundles(WebApplication app)
        {
            var env = app.Environment;

            // Use Webpack or other bundling tools to bundle and minify scripts.
            // Serve static files from wwwroot folder.
            app.UseStaticFiles();

            // Example: Add custom middleware for serving bundled files if needed.
            // This assumes you have pre-bundled files using a tool like Webpack.
            app.MapWhen(context => context.Request.Path.StartsWithSegments("/bundles/WebFormsJs"),
                builder => builder.UseStaticFiles());

            app.MapWhen(context => context.Request.Path.StartsWithSegments("/bundles/MsAjaxJs"),
                builder => builder.UseStaticFiles());

            app.MapWhen(context => context.Request.Path.StartsWithSegments("/bundles/modernizr"),
                builder => builder.UseStaticFiles());
        }
    }
}