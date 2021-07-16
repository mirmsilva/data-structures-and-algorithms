using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge05
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public LinkedList()
    {

    }
    public string Print()
    {
      Node current = Head;
      string nodeName = "";
      while (current != null)
      {
        nodeName = ($"({current.Value}) =>");
        Console.Write(nodeName);
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
      Console.Write($"Head = {Head.Value}");
      while (current != null)
      {
        if (num == current.Value)
        {
          Console.WriteLine($"Includes {num}");
          return true;
        }
      }
      Console.WriteLine($"Does not include {num}");
      return false;
    }

  }
}
