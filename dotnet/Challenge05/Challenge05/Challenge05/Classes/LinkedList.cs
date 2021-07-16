using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge05
{
  class LinkedList
  {
    public Node Head { get; set; }

    public LinkedList()
    {
      Insert(5);
      Includes(5);
      ToString();
    }
    public string ToString()
    {
      Node current = Head;
      string nodeName = "";
      while (current != null)
      {
        nodeName = ($"({current.Value}) =>");
        current = current.Next;

      }
      return nodeName;
    }
    public void Insert(int value)
    {
      Node node = new Node(value);
      if (Head != null)
      {
        node.Next = Head;

      }
      Head = node;
    }
    public bool Includes(int num)
    {
      Node current = Head;
      while (current != null)
      {
        if (num == current.Value)
        {
          return true;
        }
      }
      return false;
    }

  }
}
