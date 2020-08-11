using System;
using System.Collections.Generic;
using System.Text;

namespace Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate
{
    public interface IBackgroundJob
    {
        string Id { get; set; }
        BackgroundJobType BackgroundJobType { get; set; }

    }
}
