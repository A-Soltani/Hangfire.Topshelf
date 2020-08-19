using System;
using System.Collections.Generic;
using System.Text;
using Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate.BackgroundJobState;

namespace Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate
{
    public class RecurringBackgroundJob : IBackgroundJob
    {
        public string Id { get; set; }
        public BackgroundJobType BackgroundJobType { get; set; }
        public BackgroundJobStateType StateType { get; set; }
        public Action MethodCall { get; set; }

        private RecurringBackgroundJob()
        {
            BackgroundJobType = BackgroundJobType.Recurring;
        }

        public RecurringBackgroundJob CreateRecurringBackgroundJob() => new RecurringBackgroundJob();

    }
}
