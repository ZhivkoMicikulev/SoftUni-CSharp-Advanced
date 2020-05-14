using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.Sets_of_Elements
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var first = new HashSet<int>();
            var second = new HashSet<int>();
           
            var n = int.Parse(input[0]);
            var m = int.Parse(input[1]);
            for (int i = 0; i < n; i++)
            {
                var inp = int.Parse(Console.ReadLine());
                first.Add(inp);
            }
            for (int i = 0; i < m; i++)
            {
                var inp = int.Parse(Console.ReadLine());
                second.Add(inp);
            }
           var final = first.Intersect(second);
            Console.WriteLine(string.Join(' ',final));
            
            
        }
    }
}
