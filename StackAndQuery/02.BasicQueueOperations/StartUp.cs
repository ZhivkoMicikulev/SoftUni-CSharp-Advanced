using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var numbersToEnque = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var numbers = new Queue<int>();

            var n = input[0];
            var s = input[1];
            var x = input[2];

            FillQueue(numbersToEnque, numbers, n);
            DeleteFromQueue(numbers, s);
            if (numbers.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(numbers.Count > 0?numbers.Min():0);
            }

        }

        private static void DeleteFromQueue(Queue<int> numbers, int s)
        {
            for (int i = 0; i < s; i++)
            {
                numbers.Dequeue();
            }
        }

        private static void FillQueue(int[] numbersToEnque, Queue<int> numbers, int n)
        {
            for (int i = 0; i < n; i++)
            {
                numbers.Enqueue(numbersToEnque[i]);
            }
        }
    }
}
