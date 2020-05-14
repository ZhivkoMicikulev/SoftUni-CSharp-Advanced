using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var dic = new Dictionary<char, int>();
            for (int i = 0; i < text.Length; i++)
            {
                var ch = text[i];
                if (!dic.ContainsKey(ch))
                {
                    dic[ch] = 0;
                }
                dic[ch]++;
            }
            foreach (var el in dic.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{el.Key}: {el.Value} time/s");
            }
        }
    }
}
