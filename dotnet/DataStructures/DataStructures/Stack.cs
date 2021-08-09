using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class Stack <T>
  {
    public Node<T> Top { get; set; }

    //Pushes to the top of the stack
    public void Push(T value)
    {
      Node<T> node = new Node<T>(value);
      node.Next = Top;
      Top = node;
    }

    //removes the node from the top of the stack
    public Node<T> Pop()
    {
      Node<T> currentTop = Top;

      Top = currentTop.Next;

      return currentTop;
    }

    //Checks the top of the stack
    public bool Peek()
    {
      return Top != null;
    }

    //Checks is the stack is empty
    public bool IsEmpty()
    {
      if (Top != null)
      {
        return true;
      }
      return false;
    }

    static Boolean DoMatch(string character1, string character2)
    {
        if (character1 == "(" && character2 == ")")
            return true;
        else if (character1 == "{" && character2 == "}")
            return true;
        else if (character1 == "{" && character2 == "]")
            return true;
        else
            return false;
    }
 
    static Boolean areBracketsBalanced(string [] exp)
    {
        Stack<string> st = new Stack<string>();

        for (int i = 0; i < exp.Length; i++)
        {
            if (exp[i] == "{" || exp[i] == "("
                || exp[i] == "[")
                st.Push(exp[i]);
            if (exp[i] == "}" || exp[i] == ")"
                || exp[i] == "") {
                if (st.Equals(0))
                {
                    return false;
                }
                else if (!DoMatch(st.Pop(),exp[i])) {
                    return false;
                }
            }
        }
        if (st.Equals(0))
            return true;
        else
        {
            return false;
        }
    }
  
  }
}
