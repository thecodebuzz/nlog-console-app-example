
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;


namespace LeaverageDIOtherApps
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                MyApplication app = serviceProvider.GetService<MyApplication>();
                app.Run();
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddTransient<MyApplication>();

            services.AddLogging(builder =>
             {
                 builder.SetMinimumLevel(LogLevel.Information);
                 builder.AddNLog("nlog.config");
             });

        }
    }
}
