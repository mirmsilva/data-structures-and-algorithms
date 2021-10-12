using System;

namespace LinkedLists
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("-----LINKED LISTS-----");
      LinkedList list = new LinkedList();
      list.Insert(23);
      list.Append(15);
      list.Append(31);
      list.Append(13);
      list.Print();
      list.Includes(16);
    }
  }
}
