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
