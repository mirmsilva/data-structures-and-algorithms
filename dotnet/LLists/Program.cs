using System;

namespace LinkedLists
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("-----LINKED LISTS-----");
      LinkedList list = new LinkedList();
      list.Insert(12);
      list.Append(16);
      list.Append(14);
      list.Append(10);
      list.Append(18);
      list.Print();
      //list.InsertBefore(13, 5);
      //list.InsertAfter(15, 16);
      //list.Includes(16);

      LinkedList list2 = new LinkedList();
      list2.Insert(41);
      list2.Append(45);
      list2.Append(43);
      list2.Append(41);
      list2.Append(47);
      list2.Print();



    }
  }
}
