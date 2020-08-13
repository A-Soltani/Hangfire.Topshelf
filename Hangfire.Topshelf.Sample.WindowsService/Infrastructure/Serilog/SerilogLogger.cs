using System;
using System.Collections.Generic;
using System.Text;

namespace Hangfire.Topshelf.Sample.WindowsService.Infrastructure.Serilog
{
    public static class SerilogLogger
    {
       
        public ILogger static CreateSerilogLogger(IConfiguration configuration)
        {
           return new LoggerConfiguration()
                .ReadFrom.Configuration(configuration)
                .Enrich.WithProperty("ApplicationContext", Program.AppName)
                .CreateLogger();
        }
    }
}
