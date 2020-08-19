using System;
using System.Collections.Generic;
using System.Text;

namespace Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate.BackgroundJobState
{
    public interface IBackgroundJobState
    {
        BackgroundJobStateType StateType { get; set; }
    }
}
