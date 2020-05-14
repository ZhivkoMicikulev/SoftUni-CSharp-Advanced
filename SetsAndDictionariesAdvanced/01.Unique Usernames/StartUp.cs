using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.Unique_Usernames
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var set = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                set.Add(input);
            }
            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
