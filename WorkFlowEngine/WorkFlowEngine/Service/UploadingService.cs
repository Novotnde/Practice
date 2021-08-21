using System;
using WorkFlowEngine.Classes.Contracts;

namespace WorkFlowEngine.Classes
{
    public class UploadingService : IActivity
    {
        public void Run()
        {
            Console.WriteLine("New video has been uploaded to cloud storage.");
        }
    }
}