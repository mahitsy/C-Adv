using System;
using System.Collections.Generic;
using System.Linq;


public class SimpleTextEditor
{
    public static void Main()
    {

        var input = int.Parse(Console.ReadLine());
        var stack = new Stack<string>();
        var text = string.Empty;

        while (input > 0)
        {
            string[] arg = Console.ReadLine().Split();

            switch (arg[0])
            {
                case "1":
                    stack.Push(text);
                    text += arg[1];
                    break;
                case "2":
                    stack.Push(text);
                    text = text.Substring(0, text.Length - int.Parse(arg[1]));
                    break;
                case "3":
                    Console.WriteLine(text[int.Parse(arg[1])-1]);
                    break;
                case "4":
                    text = stack.Pop();
                    break;


            }

            input--;
        }

    }
}

