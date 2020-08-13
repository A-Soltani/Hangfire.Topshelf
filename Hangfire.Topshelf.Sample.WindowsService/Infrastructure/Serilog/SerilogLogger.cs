using Microsoft.Extensions.Configuration;
using Serilog;

namespace Hangfire.Topshelf.Sample.WindowsService.Infrastructure.Serilog
{
    public static class SerilogLogger
    {
       
        public static ILogger CreateSerilogLogger(IConfiguration configuration) =>
            new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .Enrich.WithProperty("ApplicationContext", Program.AppName)
                .CreateLogger();
    }
}
