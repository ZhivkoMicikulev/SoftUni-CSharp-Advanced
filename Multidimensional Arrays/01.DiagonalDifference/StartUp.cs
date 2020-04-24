using System;
using System.Linq;
using System.Collections.Generic;
namespace _01.DiagonalDifference
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new int[n,n];
            for (int row = 0; row < n; row++)
            {
                var rowValues = Console.ReadLine()
                     .Split()
                     .Select(int.Parse)
                     .ToArray();
                for (int coll = 0;  coll< n;coll ++)
                {
                    matrix[row, coll] = rowValues[coll];
                }
            }
            var diagonalOne = 0;
            var diagnalTwo = 0;
            for (int row = 0; row < n; row++)
            {
                diagonalOne += matrix[row, row];
                diagnalTwo += matrix[(n - 1 - row), row];
            }
           
          
            Console.WriteLine(Math.Abs(diagonalOne-diagnalTwo));
        }
    }
}
