using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class StackBalancedParenthesis
    {
        public void BalancedParanthesis(string exp)
        {
            Stack stck = new Stack();
            for (int i = 0; i < exp.Length; i++)
            {
                if (exp[i] == '(' || exp[i] == '[' || exp[i] == '{')
                    stck.Push(exp[i]);
                else if (exp[i] == ')' && stck.Count != 0 && (char)stck.Peek() == '(')
                    stck.Pop();
                else if (exp[i] == '}' && stck.Count != 0 && (char)stck.Peek() == '{')
                    stck.Pop();
                else if (exp[i] == ']' && stck.Count != 0 && (char)stck.Peek() == '[')
                    stck.Pop();
            }
            if (stck.Count == 0)
            {
                Console.WriteLine("Arithmetic Expression is Balanced.");
                return;
            }
            Console.WriteLine("Arithmetic Expression is not balanced.");
        }
    }
}
