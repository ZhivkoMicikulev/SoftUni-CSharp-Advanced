using System;
using System.Linq;
using System.Collections.Generic;
namespace _04.MatrixShuffling
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine()
                     .Split()
                    .Select(int.Parse)
                     .ToArray();
            var rows = size[0];
            var cols = size[1];
            var matrix = new string[rows, cols];
            ReadStringMatrix(rows, cols, matrix);
            string comand;
            while ((comand=Console.ReadLine())!="END")
            {
                var tokens = comand.Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();
                var cmd = tokens[0];
                if (cmd!="swap" || tokens.Length!=5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    var oldRow = int.Parse(tokens[1]);
                    var oldCol = int.Parse(tokens[2]);
                    var newRow = int.Parse(tokens[3]);
                    var newCol = int.Parse(tokens[4]);
                    var firstCell = IsItValidCell(matrix, oldRow, oldCol);
                    var secondCell = IsItValidCell(matrix, newRow, newCol);
                    if (firstCell == true && secondCell == true)
                    {
                        var first = matrix[oldRow, oldCol];
                        var second = matrix[newRow, newCol];
                        matrix[newRow, newCol] = first;
                        matrix[oldRow, oldCol] = second;
                        Print(matrix);
                    }
                       
                    
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
            }
        }

        private static void Print(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

         static bool IsItValidCell(string[,] matrix, int row, int col )
        {
            var valid = false;
            if(row<=matrix.GetLength(0) && row>=0
                && col<=matrix.GetLength(1) && col>=0)
            {
                valid = true;
            }
            return valid;
        }

        private static void ReadStringMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                var rowValues = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)

                     .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
        }
    }
}
