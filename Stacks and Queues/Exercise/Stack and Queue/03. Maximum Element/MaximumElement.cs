using System;
using System.Collections.Generic;
using System.Linq;


public class MaximumElement
{
    public static void Main()
    {
        var input = int.Parse(Console.ReadLine());
        var stack = new Stack<int>();
        var maxStack = new Stack<int>();
        var max = int.MinValue;

        for (int i = 0; i < input; i++)
        {


            var query = Console.ReadLine().Split().Select(int.Parse).ToArray();

            switch (query[0])
            {
                case 1:
                    {
                        if (max < query[1])
                        {
                            max = query[1];
                            maxStack.Push(query[1]);
                        }

                        stack.Push(query[1]);
                    }
                    break;
                case 2:
                    {
                        if (stack.Peek() == maxStack.Peek() && maxStack.Count > 0)
                        {
                            maxStack.Pop();
                            if (maxStack.Count > 0)
                            {
                                max = maxStack.Peek();
                            }
                            else
                            {
                                max = int.MinValue;
                            }
                        }

                        stack.Pop();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine(maxStack.Peek());

                    }
                    break;

            }


        }


    }
}

