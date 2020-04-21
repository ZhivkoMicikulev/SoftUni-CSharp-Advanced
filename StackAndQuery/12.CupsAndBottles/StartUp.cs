using System;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var cupCapacity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var filledBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var cups = new Queue<int>();
            var bottles = new Stack<int>();
            FillTheStackAndTHeQueue(cupCapacity, filledBottles, cups, bottles);
            var wastedWater = 0;
            while (cups.Any()&&bottles.Any())
            {
                var cup = cups.Peek();
                
                while (cup>0)
                {
                    var bottle = bottles.Pop();
                    if (bottle>=cup)
                    {
                        cups.Dequeue();
                        wastedWater += bottle - cup;
                        break;
                    }
                    else
                    {
                        cup -= bottle;
                    }

                }
                
            }
            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(' ',cups)}");
            }
            else if (bottles.Any())
            {
                bottles.Reverse();
                Console.WriteLine($"Bottles: {string.Join(' ', bottles)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");

        }

        private static void FillTheStackAndTHeQueue(int[] cupCapacity, int[] filledBottles, Queue<int> cups, Stack<int> bottles)
        {
            for (int i = 0; i < cupCapacity.Length; i++)
            {
                cups.Enqueue(cupCapacity[i]);
            }
            for (int i = 0; i < filledBottles.Length; i++)
            {
                bottles.Push(filledBottles[i]);
            }
        }
    }
}
