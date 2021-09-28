using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class LinkedList<T>
  {
    public Node<T> Head { get; set; }

    public LinkedList()
    {
    }
    //This will print the node list
    public string Print()
    {
      Node<T> current = Head;
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
    public void Insert(T value)
    {
      Node<T> node = new Node<T>(value);
      if (Head != null)
      {
        node.Next = Head;

      }
      Head = node;
    }
    public void Append(T value)
    {
      Node<T> node = new Node<T>(value);
      if (Head == null)
      {
        Head = node;
        return;
      }
      Node<T> current = Head;
      while (current.Next != null)
      {
        current = current.Next;
      }
      current.Next = node;
    }

    public void InsertBefore(T value, T newValue)
    {
      Node<T> node = new Node<T>(newValue);
      Node<T> current = Head;
      Node<T> tempNode = current;
      while (!current.Value.Equals(value))
      {
        if (current.Next.Value.Equals(value))
        {
          tempNode = current.Next;
          current.Next = node;
          node.Next = tempNode;
        }
        break;
      }
    }

    public void InsertAfter(T value, T newValue)
    {
      Node<T> newNode = new Node<T>(newValue);
      Node<T> current = Head;
      Node<T> tempNode = current;
      while (current != null)
      {
        if (current.Value.Equals(value))
        {

          tempNode = current.Next;
          current.Next = newNode;
          newNode.Next = tempNode;
          break;
        }
        current = current.Next;
      }
    }

    //Take in two lists and add them into one list
    public LinkedList<T> ZippedLinkedList(LinkedList<T> List1, LinkedList<T> List2)
    {
      //make a new zipped list
      LinkedList<T> ZippedList = new LinkedList<T>();
      //create and set node one to the list1 head value
      Node<T> one = List1.Head;
      //create and set node two to the list2 head value
      Node<T> two = List2.Head;

      while (one != null && two != null)
      {
        //Call the Append method created up above
        ZippedList.Append(one.Value);
        ZippedList.Append(two.Value);

        //This will cause it to iterate
        one = one.Next;
        two = two.Next;
      }
      Head = ZippedList.Head;
      return ZippedList;
    }

    //static Node Reverse(Node head)
    //{
    //   Node prev = null;
    //   Node current = head;
    //   Node next = null;
    //   while (current != null)
    //        {
    //            next = current.next;
    //            current.next = prev;
    //            prev = current;
    //            current = next;
    //        }
    //        return prev;
    //}


  }
}
