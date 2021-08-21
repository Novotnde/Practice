using System;
using WorkFlowEngine.Classes.Contracts;

namespace WorkFlowEngine.Classes
{
    public class WebService : IActivity
    {
        public void Run()
        {

            Console.WriteLine("The video is ready for encoding.");
        }
    }
}