using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = numb[0];
            var s = numb[1];
            var x = numb[2];
           var givenNumb= Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stac = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                stac.Push(givenNumb[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stac.Pop();
            }
            if (stac.Contains(x))
            {
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine(stac.Count > 0 ? stac.Min():0);
            }
            
            
        }
    }
}
