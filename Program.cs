using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSystemWebAdapters()
    .AddWrappedAspNetCoreSession()
    .AddJsonSessionSerializer(options =>
    {
        options.RegisterKey<string>("MachineName");
        options.RegisterKey<string>("SessionStartTime");
    });

// Add Razor Pages or MVC services as needed.
builder.Services.AddRazorPages(); // For Razor Pages
builder.Services.AddControllersWithViews(); // For MVC

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();
app.UseSystemWebAdapters();

app.MapRazorPages(); // For Razor Pages
app.MapControllers() // For MVC
    .RequireSystemWebAdapterSession(); // Ensure session is required for MVC

app.Run();