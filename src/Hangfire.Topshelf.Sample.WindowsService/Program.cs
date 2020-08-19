using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Serilog;
using static Hangfire.Topshelf.Sample.WindowsService.Infrastructure.Serilog.SerilogLogger;

namespace Hangfire.Topshelf.Sample.WindowsService
{
    class Program
    {
        public static readonly string Namespace = typeof(Program).Namespace;
        public static readonly string AppName = Namespace.Substring(Namespace.LastIndexOf('.', Namespace.LastIndexOf('.') - 1) + 1);

        static void Main(string[] args)
        {
            // DI
            RegisterServices();

            var configuration = GetConfiguration();
            Log.Logger = CreateSerilogLogger(configuration);

            try
            {
                Log.Information("Configuring Windows service ({ApplicationContext})...", AppName);
                //var service = BuildWindowsService();


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }


        private static void RegisterServices()
        {
            
        }

        private static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            return builder.Build();
        }
    }
}
