using System;
using System.Net.Http.Headers;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to stopwatch, please type in 'start' to start the timer and 'stop' whenever you are ready.");
      
            var stopWatch = new StopWatch();
            

            while (true)
            {
                var userInput = Console.ReadLine().ToLower();
                switch (userInput)
                {
                    case "start":
                       stopWatch.Start();
                        break;
                    case "stop":
                        var interval = stopWatch.Stop();
                        Console.WriteLine(interval.TotalSeconds);
                        break;
                    default:
                        Console.WriteLine("sorry, we dont know this command, please try again");
                        break;
                }
            }

        }
    }

    public class StopWatch
    {
        private bool _isActive;
        private DateTime _startTime;
        
        public void Start()
        {
            try
            {
                if (_isActive) throw new InvalidOperationException();
                _isActive = true;
                _startTime = DateTime.Now;
            }
            catch (Exception e)
            {
                Console.WriteLine("Something unexpected happened during start of stopwatch" + e);
            }
          
        }

        public TimeSpan Stop()
        {
            if (!_isActive) throw new InvalidOperationException();
            _isActive = false;
            var stopTime = DateTime.Now;

            return  stopTime - _startTime;

        }
    }
}