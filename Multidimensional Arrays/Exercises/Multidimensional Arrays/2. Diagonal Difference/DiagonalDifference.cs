using System;
using System.Linq;
using System.Numerics;

public class DiagonalDifference
{
    public static void Main()
    {

        var size = int.Parse(Console.ReadLine());
        int[,] square = new int[size, size];

        for (int i = 0; i < square.GetLength(0); i++)
        {

            var row = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int j = 0; j < square.GetLength(1); j++)
            {
                square[i, j] = row[j];
            }

        }

        long primary = 0;
        long secondary = 0;

        for (int i = 0; i < square.GetLength(0); i++)
        {
            primary += square[i, i];
            secondary += square[i, square.GetLength(1) - i - 1];
        }

        Console.WriteLine(Math.Abs(primary-secondary));
    }
}

