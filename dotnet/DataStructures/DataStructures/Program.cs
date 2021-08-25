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
        HashTableFun();
    }

    static void HashTableFun()
    {
        HashMap people = new HashMap(48);
        people.Set("John", "Husband");
        people.Set("Cathy", "Boss");
        people.Set("Allie", "Volleyballer");
        people.Set("Zach", "College Grad");
        people.Set("Rosie", "Dog");
        people.Set("Char", "Sister-In-Law");
        people.Set("Joe", "Brother");
        people.Set("Danny", "Sister");

        people.Print();

        Console.WriteLine($"Has Zach? {people.Contains("Zach")}");
        Console.WriteLine($"Has Fred? {people.Contains("Fred")}");
        Console.WriteLine($"Char? {people.Get("Char")}");

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


