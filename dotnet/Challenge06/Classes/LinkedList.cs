using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge06
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public LinkedList()
    {
    }
    //This will print the node list
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
    //This will allow you to insert nodes 
    public void Insert(int value)
    {
      Node node = new Node(value);
      if (Head != null)
      {
        node.Next = Head;

      }
      Head = node;
    }
    public void Append(int value)
    {
      Node node = new Node(value);
      if(Head ==null)
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

    public void InsertBefore(int value, int newValue)
    {
      Node node = new Node(newValue);
      Node current = Head;
      Node tempNode = current;
      while (current.Value != value)
      {
        if (current.Next.Value == value)
        {
          tempNode = current.Next;
          current.Next = node;
          node.Next = tempNode;
        }
        break;
      }
    }

    public void InsertAfter(int value, int newValue)
    {
      Node newNode = new Node(newValue);
      Node current = Head;
      Node tempNode = current;
      while (current != null)
      {
        if (current.Value == value)
        {

          tempNode = current.Next;
          current.Next = newNode;
          newNode.Next = tempNode;
          break;
        }
        current = current.Next;
      }
    }
    //recursive is nicer to look at but less efficient
    public static int IterateListRecursively (Node <int> node, int largest)
    {
      if (node.Next == null)
      {
        return largest;
      }
      if (node.Next > largest)
      {
        largest = node.Value;
      }
      return IterateListRecursively(node.Next, largest)
    }

    // iterate a list
    public static int IterateLinkedListIteratively(LinkedList<int> list)
    {
      ints largest = list.Head.Value;
      Node<int> current = list.Head;
      while (current != null)
      {
        if (current.Value > largest)
        {
          largest = current.Value;
        }
        current = current.Next;
      }
      return largest;

    }
  }
}
