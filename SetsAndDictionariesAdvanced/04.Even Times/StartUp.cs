using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dic = new Dictionary<string,int>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                if (!dic.ContainsKey(input))
                {
                    dic[input] = 0;
                }
                dic[input]++;
            }
            foreach (var el in dic.Where(x=>x.Value % 2==0))
            {
                Console.WriteLine(el.Key);
            }
        }
    }
}
