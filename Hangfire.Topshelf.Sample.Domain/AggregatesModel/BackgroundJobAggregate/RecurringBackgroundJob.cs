using System;
using System.Collections.Generic;
using System.Text;

namespace Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate
{
    public class RecurringBackgroundJob : IBackgroundJob
    {
        public string Id { get; set; }
        public BackgroundJobType BackgroundJobType { get; set; }
        private RecurringBackgroundJob()
        {
            BackgroundJobType = BackgroundJobType.Recurring;
        }

        public RecurringBackgroundJob CreateRecurringBackgroundJob() => new RecurringBackgroundJob();

    }
}
