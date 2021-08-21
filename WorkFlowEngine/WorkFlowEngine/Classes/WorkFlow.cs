using System.Collections.Generic;
using WorkFlowEngine.Classes.Contracts;

namespace WorkFlowEngine.Classes
{
    public class WorkFlow
    {
        private readonly List<IActivity> _activities;
        public WorkFlow(List<IActivity>activities)
        {
            _activities = activities;
        }
        public void Execute()
        {
            foreach (var activity in _activities)
            {
                activity.Run();
            }
        }
    }
}