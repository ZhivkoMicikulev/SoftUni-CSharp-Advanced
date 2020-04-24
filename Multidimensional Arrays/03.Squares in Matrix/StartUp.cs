using System;
using System.Linq;
using System.Collections.Generic;
namespace _03.Squares_in_Matrix
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
            var matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                var rowValues = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowValues[col];
                }
            }
            var sum = int.MinValue;
            var winnerMat = new int[3, 3];
            var indexRow = 0;
            var indexCol = 0;
            for (int row = 0; row <= rows - 3; row++)
            {
                for (int col = 0; col <= cols - 3; col++)
                {
                    var momentSum = matrix[row, col]
                         + matrix[row + 1, col]
                         + matrix[row + 2, col]
                         + matrix[row, col + 1]
                         + matrix[row, col + 2]
                         + matrix[row + 1, col + 1]
                         + matrix[row + 2, col + 2]
                         + matrix[row + 1, col + 2]
                         + matrix[row + 2, col + 1];
                    if (momentSum>sum)
                    {
                        sum = momentSum;
                        indexRow = row;
                        indexCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {sum}");
            for (int row = indexRow; row <=indexRow+2; row++)
            {
                for (int col = indexCol; col <= indexCol+2; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
