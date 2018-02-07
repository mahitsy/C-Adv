using System;
using System.Linq;


public class MatrixОfPalindromes
{
    public static void Main()
    {
        var sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var matrix = new string[sizes[0], sizes[1]];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = ((char)('a' + i)).ToString() + (char)('a' + i + j) + (char)('a' + i);
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + " ");
            }

            Console.WriteLine();
        }
    }
}

