using System;
using System.Collections.Generic;
using WorkFlowEngine.Classes;
using WorkFlowEngine.Classes.Contracts;

namespace WorkFlowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var activities = new List<IActivity>(){new UploadingService(), new WebService(), new NotificationService(), new ProcessingService()};
            var workFlow = new WorkFlow(activities);
            workFlow.Execute();
        }
    }
}