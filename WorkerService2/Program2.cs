using Microsoft.Extensions.Logging.Configuration;
using Microsoft.Extensions.Logging.EventLog;

namespace WorkerService2
{
    public class Program2
    {
        public static void Main(string[] args)
        {

        }
        public delegate int ConfigureServicesDelegate(IServiceCollection services);
        public static void RunHost(string[] args, ConfigureServicesDelegate configureServices)
        {
            /*IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>();
                })
                .Build();

            host.Run();*/

            IHostBuilder builder = Host.CreateDefaultBuilder(args)
                .UseWindowsService(options =>
                {
                    options.ServiceName = ".NET Joke Service";
                })
                .ConfigureServices((context, services) =>
                {
                    LoggerProviderOptions.RegisterProviderOptions<
                        EventLogSettings, EventLogLoggerProvider>(services);

                    configureServices(services);

                    // See: https://github.com/dotnet/runtime/issues/47303
                    services.AddLogging(builder =>
                    {
                        builder.AddConfiguration(
                            context.Configuration.GetSection("Logging"));
                    });
                });

            IHost host = builder.Build();
            host.Run();

        }
    }
}