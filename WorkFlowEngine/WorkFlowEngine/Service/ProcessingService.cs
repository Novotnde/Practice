using System;
using WorkFlowEngine.Classes.Contracts;

namespace WorkFlowEngine.Classes
{
    public class ProcessingService : IActivity
    {
        public void Run()
        {
            Console.WriteLine("Changing the status to 'Processing'.");
        }
    }
}