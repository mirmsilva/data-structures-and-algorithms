using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class PseudoQueue<T>
  {
    //create two new stacks
    public Stack<T> stackOne = new Stack<T>();
    public Stack<T> stackTwo = new Stack<T>();

    //create Enqueue method()
    public void Enqueue(T val)
    {
      //add nodes to stackOne using .Push() (just to put stuff in)
      stackOne.Push(val);
      
    }
    //create Dequeue method()
    public void Dequeue()
    {
      //while stackOne is true
      while (stackOne.Peek() == true)
      {
        //add the nodes from stackOne into stackTwo using .Push() (create one)
        stackOne.Push(stackTwo.Pop().Value);
      }
    
    }
  }
}
