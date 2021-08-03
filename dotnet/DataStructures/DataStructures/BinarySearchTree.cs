using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  //"where T : IComparable" allows you to compare generic values
  public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable
  {
    public void Add(Node<T> node, T value)
    {
      //1.make a node
      //2. if we don't have a root make that node a root
      //3. if the value is < the "node" i'm looking at add it to the left
        //if we don't have a left, add it & be done
        //if we do have a left, call this method again with the left node
      //3. if the value is > the "node" i'm looking at add it to the right
        //if we don't have a right, add it & be done
        //if we do have a right, call this method again with the right node

      Node<T> newNode = new Node<T>(value);
      if (Root == null)
      {
        Root = newNode;
        return;
      }
      //#3 LEFT SIDE 
      //.CompareTo is similar to .Equals
      if (newNode.Value.CompareTo(node.Value) < 0)
      {
        if (node.Left == null)
        {
          node.Left = newNode;
        }
        else
        {
          Add(node.Left, value);
        }
      }
      //#3 RIGHT SIDE
      else if (newNode.Value.CompareTo(node.Value) > 0)
      {
        if (node.Right == null)
        {
          node.Right = newNode;
        }
        else
        {
          Add(node.Right, value);
        }
      }
    }
  }
}
