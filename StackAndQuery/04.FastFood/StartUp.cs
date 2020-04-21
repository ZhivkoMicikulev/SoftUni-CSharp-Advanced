using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.FastFood
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var quantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var queue = new Queue<int>();
            FillQueue(orders, queue);
            var sum = 0;
            while (queue.Any())
            {
                var order = queue.Peek();
                sum +=order;
                if (sum>quantity)
                { 
                  break;
                }
                else
                {
                    queue.Dequeue();
                }
            }
            Console.WriteLine(orders.Max());
            if (queue.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(' ',queue)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }

        private static void FillQueue(int[] orders, Queue<int> queue)
        {
            for (int i = 0; i < orders.Length; i++)
            {
                queue.Enqueue(orders[i]);
            }
        }
    }
}
