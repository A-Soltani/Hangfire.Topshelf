using System;
using Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate.BackgroundJobState;
using Xunit;

namespace Hangfire.Topshelf.Sample.UnitTests.Domain.AggregatesModel.BackgroundJobAggregate
{
    public class BackgroundJobStateFactory
    {
        private readonly IBackgroundJobStateFactory _backgroundJobStateFactory;

        public BackgroundJobStateFactory(IBackgroundJobStateFactory backgroundJobStateFactory) => _backgroundJobStateFactory = backgroundJobStateFactory ?? throw  new ArgumentNullException(nameof(backgroundJobStateFactory));

        [Fact]
        public void GetState_BackgroundJobStateTypeIsWaiting_WaitingStateShouldBeReturned()
        {
            var stateType = BackgroundJobStateType.Waiting;

            var backgroundJobState = _backgroundJobStateFactory.GetState(stateType);

            Assert.IsType<WaitingBackgroundJobState>(backgroundJobState);
        }
    }
}
