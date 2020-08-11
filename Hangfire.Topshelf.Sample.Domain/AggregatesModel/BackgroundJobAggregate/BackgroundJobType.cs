namespace Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate
{
    public enum BackgroundJobType
    {
        FireAndForget,
        Delayed,
        Recurring
    }
}