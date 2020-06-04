using System;
using System.Linq;

namespace _07.Predicate_For_Names
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Func<string, bool> predicate = name => name.Length <= n;
            Console.WriteLine(string.Join(Environment.NewLine,names.Where(predicate)));
         

            
        }
    }
}
