using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Action_Point
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

            Action<List<string>> action = (name) =>
                      Console.WriteLine(string.Join(Environment.NewLine, name));
            action(names);

        }
    }
}
