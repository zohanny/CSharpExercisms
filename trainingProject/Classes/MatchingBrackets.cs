using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        
        string openSymbols = "({[";
        string closeSymbols = ")}]";
        Stack<char> stack = new Stack<char>();  

        foreach (char  c in input)
        {
            if (openSymbols.Contains(c))
            {
                stack.Push(c);
            }
           
            if (closeSymbols.Contains(c))
            {
                if (stack.Count==0 || openSymbols.IndexOf(stack.Peek()) != closeSymbols.IndexOf(c))
                    return false;
                else
                    stack.Pop();
            }
        }
        if (stack.Count != 0)
            return false;
        else
            return true;
    }
}