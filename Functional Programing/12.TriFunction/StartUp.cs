using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace _12.TriFunction
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Func<string, int, bool> sizeOfName = (x, y) => x.Sum(ch => ch) >= y;
            Func<Func<string, int, bool>, List<string>, string> returnFirst = (x, y) => y.FirstOrDefault(s => x(s, n));

            var result = returnFirst(sizeOfName, names);
            Console.WriteLine(result);
          
           
        }
    }
}
