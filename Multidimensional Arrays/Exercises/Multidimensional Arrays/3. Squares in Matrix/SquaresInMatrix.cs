using System;
using System.Linq;


public class SquaresInMatrix
{
    public static void Main()
    {
        var sizes = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var matrix = new int[sizes[0], sizes[1]];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = input[j];
            }
        }

        int output = 0;

        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                var currentchar = matrix[i, j];
                if (currentchar == matrix[i, j + 1] && currentchar == matrix[i + 1, j] && currentchar == matrix[i + 1, j + 1])
                {
                    output++;
                }
            }
        }

        Console.WriteLine(output);
    }
}
