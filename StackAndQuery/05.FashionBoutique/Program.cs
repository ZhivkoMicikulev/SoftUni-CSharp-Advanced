using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var capacity = int.Parse(Console.ReadLine());
            var box = new Stack<int>();
            PushToStack(sequence, box);
            var boxes = 0;
            var sum = 0;
            while (box.Any())
            {
                var clothes = box.Peek();
                sum += clothes;
                if (sum >= capacity)
                {
                    if (sum == capacity)
                    {
                        box.Pop();
                    }
                    boxes++;
                    sum = 0;
                }
                else
                {
                    box.Pop();
                    if (box.Count == 0)
                    {
                        boxes++;
                    }
                }
               
            }
            Console.WriteLine(boxes);

        }

        private static void PushToStack(int[] sequence, Stack<int> box)
        {
            for (int i = 0; i < sequence.Length; i++)
            {
                box.Push(sequence[i]);
            }
        }
    }
}
