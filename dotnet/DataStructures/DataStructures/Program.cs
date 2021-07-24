using System;

namespace DataStructures
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      LinkedList OurList = new LinkedList { };
      OurList.Insert(2);
      OurList.Append(7);
      OurList.Append(9);
      OurList.Append(3);
      OurList.Append(4);
      //OurList.InsertBefore(9, 1);
      //OurList.InsertAfter(7, 5);
      OurList.Print();
    }
  }
}
