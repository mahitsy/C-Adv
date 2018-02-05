using System;
using System.Collections.Generic;
using System.Linq;


public class BalancedParenthesis
{
    public static void Main()
    {
        var input = Console.ReadLine().ToCharArray();
        var parenthesesStack = new Stack<char>();

        var isBalanced = true;

        var parentheses = new Dictionary<char, char>
        {
            {'{', '}'},
            { '[', ']'},
            { '(', ')'}
        };

        for (int i = 0; i < input.Length; i++)
        {
            if (parentheses.ContainsKey(input[i]))
            {
                parenthesesStack.Push(input[i]);
            }
            else if (parenthesesStack.Count == 0 || input[i] != parentheses[parenthesesStack.Peek()])
            {
                isBalanced = false;
                break;
            }
            else if (input[i] == parentheses[parenthesesStack.Peek()])
            {
                parenthesesStack.Pop();
            }
        }
        if (isBalanced) Console.WriteLine("YES");

        else Console.WriteLine("NO");
    }
}

