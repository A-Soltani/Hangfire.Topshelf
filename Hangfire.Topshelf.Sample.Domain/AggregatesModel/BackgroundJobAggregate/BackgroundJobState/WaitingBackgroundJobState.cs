namespace Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate.BackgroundJobState
{
    public class WaitingBackgroundJobState: IBackgroundJobState
    {
        public BackgroundJobStateType StateType { get; set; }

        private WaitingBackgroundJobState() => StateType = BackgroundJobStateType.Waiting;

        public static WaitingBackgroundJobState CreateState() => new WaitingBackgroundJobState();
    }
}