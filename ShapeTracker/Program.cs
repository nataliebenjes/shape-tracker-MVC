using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace ShapeTracker
{
  class Program
  {
    static void Main(string[] args)
    {
      WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

  builder.Services.AddControllersWithViews();

  WebApplication app = builder.Build();

  app.UseRouting();

  app.MapControllerRoute(
      name: "default",
      pattern: "{controller=Shape}/{action=Index}/{id?}"
  );

  app.Run();
  
    }
  }
}