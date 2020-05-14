using System;
using System.Collections.Generic;
using System.Linq;
namespace _03.Periodic_Table
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var table = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < input.Length; j++)
                {
                    table.Add(input[j]);
                }
            }
            Console.WriteLine(string.Join(' ',table));
        }
    }
}
