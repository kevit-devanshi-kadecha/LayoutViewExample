using ServiceContracts;
using Services;

namespace LayoutViewExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddTransient<ICitiesService, CitiesService>();

            builder.Services.Add(new ServiceDescriptor(
                typeof(ISalaryService),
                typeof(SalaryService),
                ServiceLifetime.Transient
            ));
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseRouting();
            app.MapControllers();

            app.Run();
        }
    }
}
