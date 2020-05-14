using System;
using System.Collections.Generic;
using System.Linq;
namespace _06.Wardrobe
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wardrobe = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var clothes = input[1].Split(',', StringSplitOptions.RemoveEmptyEntries).ToArray();
                var color = input[0];
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    var item = clothes[j];
                    if (!wardrobe[color].ContainsKey(item))
                    {
                        wardrobe[color][item] = 0;
                    }
                    wardrobe[color][item]++;
                }
            }
            var choice = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            var choiceColor = choice[0];
            var cloth = choice[1];
            foreach (var item in wardrobe)
            {
                var itemColor = item.Key;
                Console.WriteLine($"{itemColor} clothes:");
                var clothes = item.Value;
                foreach (var cl in clothes)
                {
                    var itemCloth = cl.Key;
                    if (choiceColor==itemColor && itemCloth==cloth)
                    {
                        Console.WriteLine($"* {itemCloth} - {cl.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {itemCloth} - {cl.Value}");
                    }
                }
            }
        }
    }
}
