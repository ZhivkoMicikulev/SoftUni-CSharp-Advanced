﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Find_Evens_or_Odds
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var query = Console.ReadLine();
            Predicate<int> predicate = query == "odd" ? new Predicate<int>
                ((n) => n % 2 != 0) : new Predicate<int>((n) => n % 2 == 0);
            var result = new List<int>();
            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }
           
                Console.WriteLine(string.Join(' ',result));
            
        }
    }
}
