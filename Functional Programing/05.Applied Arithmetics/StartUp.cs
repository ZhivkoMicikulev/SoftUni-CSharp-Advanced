using System;
using System.Linq;

namespace _05.Applied_Arithmetics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input == "print")
                {
                    Console.WriteLine(string.Join(' ',numbers));
                }
                else
                {
                    Func<int[], int[]> procesor = GetProcesor(input);
                    numbers = procesor(numbers);
                }

            }
        }
        static Func<int[], int[]> GetProcesor(string input)
        {
            Func<int[], int[]> procesor=null;
            if (input == "add")
            {
                procesor = new Func<int[], int[]>((arr) =>
                 {
                     for (int i = 0; i < arr.Length; i++)
                     {
                         arr[i]++;
                     }
                     return arr;
                 });
            }
            else if (input == "multiply")
            {
                procesor = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] *= 2;
                    }
                    return arr;
                });
            }
            else if (input == "subtract")
            {
                procesor = new Func<int[], int[]>((arr) =>
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i]--;
                    }
                    return arr;
                });
            }
            return procesor;

        }
    }
}
