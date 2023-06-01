
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WorkerService2.Program2.RunHost(args, ConfigureServices);
        }

        static int ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<JokeService>();
            services.AddHostedService<WindowsBackgroundService>();

            return 1;
        }
    }
}