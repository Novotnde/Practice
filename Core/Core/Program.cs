using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Core
{
    class Program
    {
        private static void Main(string[] args)
        {
            const int number = 10;
            var numbers = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            Console.WriteLine(string.Join(",",  ReturnOddNumbers(numbers)));
            Console.WriteLine(string.Join(",",  ReturnNumbers(number)));

        }

        private static IEnumerable<int> ReturnOddNumbers( IEnumerable<int> numbers)
        {
            return numbers.Where(IsNumberOdd);
        }
        
        private static bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        private static IEnumerable<int> ReturnNumbers(int num)
        {
            for (var i = 0; i <= num; i++)
            {
                yield return i;
            }
        }
    }
}