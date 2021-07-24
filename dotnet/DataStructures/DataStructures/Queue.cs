using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class Queue<T>
  {
    public Node<T> Front { get; set; }
    public Node<T> Back { get; set; }


    //adding to the top of the Queue
    public void Enqueue(T value)
    {
      Node<T> node = new Node<T>(value);
      if (Front == null)
      {
        Front = node;
        Back = node;
      }
      else
      {
        Back.Next = node;
        Back = node;
      }
    }

    //removing from the top of the Queue
    public Node<T> Dequeue()
    {
      Node<T> currentFront = Front;

      Front = Front.Next;

      return currentFront;
    }
    //return top value
    //the front should be null if it's the top
    public bool Peek()
    {
      return Front != null;
    }
    //is there a front node?
    public bool IsEmpty()
    {
      if (Front != null)
      {
        return true;
      }
      return false;
    }
  }
}

