using System;
using System.Collections.Generic;
using System.Text;
using Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate.BackgroundJobState;

namespace Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate
{
    public interface IBackgroundJob
    {
        string Id { get; set; }
        BackgroundJobType BackgroundJobType { get; set; }
        BackgroundJobStateType StateType { get; set; }
        Action MethodCall { get; set; }
    }
}
