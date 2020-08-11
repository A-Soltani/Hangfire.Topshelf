﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hangfire.Topshelf.Sample.Domain.AggregatesModel.BackgroundJobAggregate.BackgroundJobState
{
    public class BackgroundJobStateFactory
    {
        private readonly IEnumerable<IBackgroundJobState> _backgroundJobStates;

        public BackgroundJobStateFactory(IEnumerable<IBackgroundJobState> backgroundJobStates) => _backgroundJobStates = backgroundJobStates ?? throw new ArgumentNullException(nameof(backgroundJobStates));

        public IBackgroundJobState GetState(BackgroundJobStateType stateType) 
            => _backgroundJobStates.FirstOrDefault(b => b.StateType == stateType);
    }
}
