using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MatchingBrackets
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var stackOpenBracketIndex = new Stack<int>();

        for (int counter = 0; counter < input.Length; counter++)
        {
            if (input[counter] == '(')
            {
                stackOpenBracketIndex.Push(counter);
            }

            if (input[counter] == ')')
            {
                var openBracketIndex = stackOpenBracketIndex.Pop();
                var lenght = counter - openBracketIndex + 1;
                Console.WriteLine(input.Substring(openBracketIndex, lenght));
            }
        }
    }
}

