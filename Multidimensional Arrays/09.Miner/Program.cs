using System;
using System.Linq;
using System.Collections.Generic;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var mine = new string[n, n];
            var comands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            ReadTheMatrix(n, mine);
            var sRow = 0;
            var sCol = 0;
            FindingStartIndexes(mine, ref sRow, ref sCol);
            var coals = 0;
            coals = FindingCoalsNumber(n, mine, coals);
            
            var colect = false;
            var endRoute = false;
            for (int i = 0; i < comands.Length; i++)
            {
                var move = comands[i];
                var momentRow = sRow;
                var momentCol = sCol;
                switch (move)
                {
                    case "up":
                        momentRow -= 1;
                        break;
                    case "right":
                        momentCol += 1;
                        break;
                    case "left":
                        momentCol -= 1;
                        break;
                    case "down":
                        momentRow += 1;
                        break;
                }
                var isValid = IsValid(mine, momentRow, momentCol);
                if (isValid == true)
                {
                    if (mine[momentRow, momentCol] == "e")
                    {
                        Console.WriteLine($"Game over! ({momentRow}, {momentCol})");
                        endRoute = true;
                        break;
                    }
                    else if (mine[momentRow, momentCol] == "c")
                    {
                        coals--;
                        mine[momentRow, momentCol] = "*";
                        if (coals==0)
                        {
                            Console.WriteLine($"You collected all coals! ({momentRow}, {momentCol})");
                            colect = true;
                            break;
                        }
                    }
                    sRow = momentRow;
                    sCol = momentCol;
                }
            }
            if (colect == false && endRoute == false)
            {
                Console.WriteLine($"{coals} coals left. ({sRow}, {sCol})");
            }


        }

        private static int FindingCoalsNumber(int n, string[,] mine, int coals)
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (mine[row, col] == "c")
                    {
                        coals++;
                    }
                }
            }

            return coals;
        }

        static bool IsValid(string[,] mine,int row, int col)
        {
             var isValid = false;
            if (row>=0 && row<=mine.GetLength(0)-1
                && col>=0 && col<=mine.GetLength(1)-1)
            {
                isValid = true;
            }
            return isValid;
        }

        private static void ReadTheMatrix(int n, string[,] mine)
        {
            for (int row = 0; row < n; row++)
            {
                var rowValues = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();
                for (int col = 0; col < n; col++)
                {
                    mine[row, col] = rowValues[col];
                }
            }
        }

        private static void FindingStartIndexes(string[,] mine, ref int sRow, ref int sCol)
        {
            for (int row = 0; row < mine.GetLength(0); row++)
            {
                for (int col = 0; col < mine.GetLength(1); col++)
                {
                    if (mine[row, col] == "s")
                    {
                        sRow = row;
                        sCol = col;
                    }
                }
            }
        }
    }
}
