using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = new Stack<int>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var cmdArgs = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                var cmd = cmdArgs[0];
                if (cmd=="1")
                {
                    var element = int.Parse(cmdArgs[1]);
                    numbers.Push(element);
                }
                else if (cmd=="2")
                {
                    if (numbers.Any())
                    {
                        numbers.Pop();
                    }
                 

                }
                else if (cmd == "3")
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (cmd == "4")
                {
                    if (numbers.Any())
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
