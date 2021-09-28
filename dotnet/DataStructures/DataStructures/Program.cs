using System;

namespace DataStructures
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      // StackIterative();
      // StackRecursive();
      // QueueIterative();
      // QueueRecursive();
      //HashTableFun();
      //GraphCoolness();
      LinkedListTest();
   
    }
    //static void GraphCoolness()
    //{
    //  Graph<string> graph = new Graph<string>();

    //  var aNode = graph.AddNode("A");
    //  var bNode = graph.AddNode("B");
    //  var cNode = graph.AddNode("C");
    //  var dNode = graph.AddNode("D");
    //  var eNode = graph.AddNode("E");

    //  graph.AddEdge(aNode, bNode, 2);
    //  graph.AddEdge(aNode, cNode, 4);
    //  graph.AddEdge(bNode, cNode, 5);
    //  graph.AddEdge(dNode, eNode, 8);
    //  graph.AddEdge(aNode, eNode, 3);

    //  Console.WriteLine("--------Graph Challenge--------");
    //  graph.GetNodes();

    //  graph.Print();
    //}
    static void HashTableFun()
    {
        HashMap people = new HashMap(48);
        people.Set("C", "N");
        people.Set("A", "C");
        people.Set("W", "Z");
        people.Set("N", "S");
        people.Set("S", "W");

        Console.WriteLine("-------Hash Table-------");

        people.Print();




    }

    //CHALLENGE 26
    //int[] arr = { 2, 6, 8, 7, 1 };
    //int[] sorted = InsertionSort.InsertionSortArray(arr);
    //for (int i = 0; i < arr.Length; i++)
    //{

    //  Console.WriteLine(sorted[i]);
    //}

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
    static void LinkedListTest()
    {
      LinkedList<string> test = new LinkedList<string>();
      test.Insert("A");
      test.Append("B");
      test.Insert("C");
      test.Print();
    }


    //BINARY TREES
  }
}


