using System;
using System.Collections.Generic;



public class ReverseStrings
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var stack = new Stack<char>(input.ToCharArray());


        while (stack.Count > 0)
        {
            Console.Write(stack.Pop().ToString());
        }

        Console.WriteLine();
    }
}

