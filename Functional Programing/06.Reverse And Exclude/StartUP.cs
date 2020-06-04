using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Reverse_And_Exclude
{
    class StartUP
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var n =int.Parse(Console.ReadLine());
            Func<int, bool> predicate = x => x % n != 0;
            Console.WriteLine(String.Join(" ", input.Where(predicate).Reverse()));

        }
    }
}
