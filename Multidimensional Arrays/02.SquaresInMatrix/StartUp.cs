using System;
using System.Linq;
using System.Collections.Generic;
namespace _02.SquaresInMatrix
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
            var matrix = new char[rows, cols];

            ReadArr(rows, cols, matrix);
            var match = 0;
            match = FindMAtch(rows, cols, matrix, match);
            Console.WriteLine(match);

        }

        private static int FindMAtch(int rows, int cols, char[,] matrix, int match)
        {
            for (int row = 0; row <= rows - 2; row++)
            {
                for (int col = 0; col <= cols - 2; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                        matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        match++;
                    }
                }
            }

            return match;
        }

        private static void ReadArr(int rows, int cols, char[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                var rowValues = Console.ReadLine()
                     .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                     .Select(char.Parse)
                     .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
        }
    }
}
