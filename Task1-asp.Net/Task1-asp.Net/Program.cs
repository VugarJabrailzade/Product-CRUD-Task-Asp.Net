using Microsoft.EntityFrameworkCore;
using Task1_asp.Net.Database;

namespace Task1_asp.Net
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews().
                             AddRazorRuntimeCompilation();

            builder.Services.AddDbContext<PustokDbContext>(v => {
                v.UseNpgsql(DatabaseConstant.Connection_String);
            });

            var app = builder.Build();

            app.UseStaticFiles();

            //app.MapGet("/", () => "Hello World!");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}");

            app.Run();
        }
    }
}