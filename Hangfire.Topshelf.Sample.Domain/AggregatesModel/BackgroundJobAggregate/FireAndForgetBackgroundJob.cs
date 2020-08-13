using System;
using System.Collections.Generic;
using System.Text;
using Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate.BackgroundJobState;

namespace Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate
{
    public class FireAndForgetBackgroundJob: IBackgroundJob
    {
        public string Id { get; set; }
        public BackgroundJobType BackgroundJobType { get; set; }
        public BackgroundJobStateType StateType { get; set; }
        public Action MethodCall { get; set; }

        public FireAndForgetBackgroundJob()
        {
            BackgroundJobType = BackgroundJobType.FireAndForget;
        }
    }
}
