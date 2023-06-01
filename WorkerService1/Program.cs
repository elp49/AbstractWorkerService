//using Microsoft.Extensions.Hosting;
using WorkerService1;

//IHostBuilder builder = Host.CreateDefaultBuilder(args);
//builder.Services;
//IHost host = builder.ConfigureServices(services =>
//    {
//        services.AddHostedService<Worker>();
//        services.AddWi
//    })
//    .Build();

//await host.RunAsync();


//using Microsoft.Extensions.Logging.Configuration;
//using Microsoft.Extensions.Logging.EventLog;

//IHostBuilder builder = Host.CreateDefaultBuilder(args)
//    .UseWindowsService(options =>
//    {
//        options.ServiceName = ".NET Joke Service";
//    })
//    .ConfigureServices((context, services) =>
//    {
//        LoggerProviderOptions.RegisterProviderOptions<
//            EventLogSettings, EventLogLoggerProvider>(services);

//        services.AddSingleton<JokeService>();
//        services.AddHostedService<WindowsBackgroundService>();

//        // See: https://github.com/dotnet/runtime/issues/47303
//        services.AddLogging(builder =>
//        {
//            builder.AddConfiguration(
//                context.Configuration.GetSection("Logging"));
//        });
//    });

//IHost host = builder.Build();
//host.Run();


WorkerService2.Program2.RunHost(args, ConfigureServices);


static int ConfigureServices(IServiceCollection services)
{

    services.AddSingleton<JokeService>();
    services.AddHostedService<WindowsBackgroundService>();

    return 1;
}

/*var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddWindowsService();
builder.Services.AddHostedService<ServiceA>();

var app = builder.Build();

app.MapRazorPages();

app.Run();*/
