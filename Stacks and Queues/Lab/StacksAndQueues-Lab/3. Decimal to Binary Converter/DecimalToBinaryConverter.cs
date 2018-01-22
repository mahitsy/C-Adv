﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DecimalToBinaryConverter
{
    public static void Main()
    {
        var inputDecimal = int.Parse(Console.ReadLine());
        var stack = new Stack<int>();

        if (inputDecimal == 0)
        {
            Console.WriteLine(0);
        }

        while (inputDecimal > 0)
        {
            stack.Push(inputDecimal % 2);
            inputDecimal /= 2;
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop());
        }
    }
}

