// See https://aka.ms/new-console-template for more information
using ConsoleApp2;
using Microsoft.Extensions.DependencyInjection;

//Console.WriteLine("Hello, World!");
WorkerService2.Program2.RunHost(args, services =>
{

    services.AddSingleton<JokeService>();
    services.AddHostedService<WindowsBackgroundService>();

    return 1;
});