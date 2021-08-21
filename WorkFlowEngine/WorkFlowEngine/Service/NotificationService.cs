using System;
using System.Threading.Channels;
using WorkFlowEngine.Classes.Contracts;

namespace WorkFlowEngine.Classes
{
    public class NotificationService : IActivity
    {
        public void Run()
        {
            Console.WriteLine("Your video is now being processed.");
        }
    }
}