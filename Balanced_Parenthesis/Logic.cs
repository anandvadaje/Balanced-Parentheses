using System;
using System.Collections;

namespace Balanced_Parenthesis
{
    class Logic
    {
        ArrayList openbrackets;
        ArrayList closebrackets;

        public Logic()
        {
            openbrackets = new ArrayList();
            openbrackets.Add('(');
            openbrackets.Add('{');
            openbrackets.Add('[');
            openbrackets.Add('<');

            closebrackets = new ArrayList();
            closebrackets.Add(')');
            closebrackets.Add('}');
            closebrackets.Add(']');
            closebrackets.Add('>');
        }

        public bool IsBalanced(string input)
        {
            Stack open = new Stack();
            foreach(char x in input)
            {
                if (openbrackets.Contains(x))
                {
                    open.Push(x);
                }

                if (closebrackets.Contains(x))
                {
                    if(open.Count == 0)
                    {
                        return false;
                    }

                    if(!IsCombination((char)open.Pop(), x))
                    {
                        return false;
                    }
                } 
            }

            if(open.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsCombination(char a, char b)
        {
            switch(a)
            {
                case '(':
                    if (b.Equals(')'))
                    {
                        return true;
                    }
                    break;
                case '[':
                    if (b.Equals(']'))
                    {
                        return true;
                    }
                    break;
                case '{':
                    if (b.Equals('}'))
                    {
                        return true;
                    }
                    break;
                case '<':
                    if (b.Equals('>'))
                    {
                        return true;
                    }
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }

            return false;
        }
    }
}
