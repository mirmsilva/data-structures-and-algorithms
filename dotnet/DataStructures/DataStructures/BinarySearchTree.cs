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

    //CONTAINS
    public bool Contains(T val)
    {
      Node<T> target = Root;
      while (target != null)
      {
        if (target.Value.CompareTo(val) == 0) return true;
        if (target.Value.CompareTo(val) < 0)
        {
          target = target.Left;
        }
        else if (target.Value.CompareTo(val) > 0)
        {
          target = target.Right;
        }
      }
      return false;
    }

    //IN-ORDER TRAVERSAL
    public static List<int> InOrderTraversal(Node<int> node, List<int> values)
    {

      if (node.Left != null) { InOrderTraversal(node.Left, values); }

      values.Add(node.Value);

      if (node.Right != null) { InOrderTraversal(node.Right, values); }

      return values;
    }

    //PRE-ORDER TRAVERSAL
    public static List<int> PreOrderTraversal(Node<int> node, List<int> values)
    {
      values.Add(node.Value);

      if (node.Left != null) { PreOrderTraversal(node.Left, values); }

      if (node.Right != null) { PreOrderTraversal(node.Right, values); }

      return values;
    }

    //POST ORDER TRAVERSAL
    public static List<int> PostOrderTraversal(Node<int> node, List<int> values)
    {

      if (node.Left != null) { PostOrderTraversal(node.Left, values); }

      if (node.Right != null) { PostOrderTraversal(node.Right, values); }

      values.Add(node.Value);

      return values;
    }

    //CHALLENGE 17: BREADTH FIRST TRAVERSAL
    //LEVEL ORDER TRAVERSAL
    public static List<int> LevelOrderTraversal(BinarySearchTree<int> tree)
    {

      List<int> values = new List<int>();
      Queue<Node<int>> nodes = new Queue<Node<int>>();

      nodes.Enqueue(tree.Root);

      while (nodes.Peek())
      {
        Node<Node<int>> node = nodes.Dequeue();
        Node<int> currentNode = node.Value;

        values.Add(currentNode.Value);

        if (currentNode.Left != null) { nodes.Enqueue(currentNode.Left); }
        if (currentNode.Right != null) { nodes.Enqueue(currentNode.Right); }

      }

      return values;
    }
  }
}
