using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
  class LinkedList
  {
    public Node Head { get; set; }

    public LinkedList()
    {

    }
    //INSERT
    //WHAT IT DOES: Adds nodes to the front of the linked list
    public void Insert(int value)
    {
      Node node = new Node(value);
      if (Head != null) //if the head is NOT null
      {
        node.Next = Head; // then the node.next will now equal the head
      }
      Head = node; // if the head is null then the node will now be the head
    }
    //APPEND
    // WHAT IT DOES: adds the node after the last node in the linked list
    public void Append(int value)
    {
      Node node = new Node(value);
      if (Head == null)
      {
        Head = node;
        return;
      }
      Node current = Head;
      while (current.Next != null)
      {
        current = current.Next;
      }
      current.Next = node;
    }

    //INCLUDES
    public bool Includes(int num)
    {
      Node current = Head;
      while (current.Next != null)
      {
        if (num == current.Value)
        {
          Console.WriteLine($" Does include {num}");
          return true;
          
        }
        current = current.Next;
      }
      Console.WriteLine($"Does not include {num}");
      return false;
    }

    //PRINT
    public void Print()
    {
      Node current = Head;
      while (current != null)
      {
        Console.Write($"({current.Value})=>");
        current = current.Next;
      }
      Console.WriteLine("NULL");
    }
  }
}
