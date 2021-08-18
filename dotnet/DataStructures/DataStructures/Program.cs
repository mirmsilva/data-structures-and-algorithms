using System;

namespace DataStructures
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");

      //CHALLENGE 26
      int[] arr = { 2, 6, 8, 7, 1 };
      int[] sorted = InsertionSort.InsertionSortArray(arr);
      for (int i = 0; i < arr.Length; i++)
      {

        Console.WriteLine(sorted[i]);
      }

      ////CHALLENGE 18: K-ARY TREE
      //KaryTree<int> IntTree = new KaryTree<int>(10);

      //IntTree.Root.Value = 10;
      //IntTree.Root.Children.Add(new Node<int>(10));
      //IntTree.Root.Children.Add(new Node<int>(3));
      //IntTree.Root.Children.Add(new Node<int>(15));

      //KaryTree<string> StringTree = IntTree.FizzBuzz(IntTree);

      //foreach (Node<string> val in StringTree.Root.Children)
      //{
      //  Console.WriteLine($"{val.Value} ");
      //}

      //LINKED LISTS
      //LinkedList OurList = new LinkedList { };
      //OurList.Insert(2);
      //OurList.Append(7);
      //OurList.Append(9);
      //OurList.Append(3);
      //OurList.Append(4);
      //OurList.InsertBefore(9, 1);
      //OurList.InsertAfter(7, 5);
      //OurList.Print();


      //BINARY TREES
    }   
  }
}

