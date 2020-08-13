using System;
using System.Collections.Generic;
using System.Text;

namespace Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate.BackgroundJobState
{
    public enum BackgroundJobStateType
    {
        Waiting = 1,
        AddedToQueue = 2, // Enqueued
        InProgress = 3,
        Success = 4,
        Fail = 5
    }
}
