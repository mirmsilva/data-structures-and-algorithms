using System;

namespace LinkedLists
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("-----LINKED LISTS-----");
      LinkedList list = new LinkedList();
      list.Insert(28);
      list.Append(15);
      list.Append(27);
      list.Append(41);
      list.Append(13);
      list.InsertBefore(13, 5);
      list.InsertAfter(15, 16);
      list.Print();
      list.Includes(16);

     

    }
  }
}
