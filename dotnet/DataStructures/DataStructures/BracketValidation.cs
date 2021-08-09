using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  //CODE CHALLENGE 13
  public class BracketValidation
  {
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

    static Boolean areBracketsBalanced(string[] exp)
    {
      Stack<string> st = new Stack<string>();

      for (int i = 0; i < exp.Length; i++)
      {
        if (exp[i] == "{" || exp[i] == "("
            || exp[i] == "[")
          st.Push(exp[i]);
        if (exp[i] == "}" || exp[i] == ")"
            || exp[i] == "")
        {
          if (st.Equals(0))
          {
            return false;
          }
          else if (!DoMatch(st.Pop(), exp[i]))
          {
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
