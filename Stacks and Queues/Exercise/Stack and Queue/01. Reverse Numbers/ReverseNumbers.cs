using System;
using System.Collections.Generic;
using System.Linq;


class ReverseNumbers
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        var stack = new Stack<int>(input);

        stack.Reverse();

        Console.WriteLine(string.Join(" ", stack));

    }
}

