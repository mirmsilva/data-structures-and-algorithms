using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  public class BinaryTree<T>
  {
    public Node<T> Root { get; set; }

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

    //MAX NODE IN TREE
    int FindMax(Node<int> root)
    {
      int CurrentMax = root.Value;
      if (root.Left != null)
      {
        int temp = FindMax(root.Left);
        if (temp > CurrentMax)
        {
          CurrentMax = temp;
        }
      }
      if (root.Right != null)
      {
        int temp = FindMax(root.Right);
        if (temp > CurrentMax)
        {
          CurrentMax = temp;
        }
      }
      return CurrentMax;
    }
  }
}
