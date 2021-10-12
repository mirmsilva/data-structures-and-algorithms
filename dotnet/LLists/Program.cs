using System;

namespace LLists
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("-----LINKED LISTS-----");
      LinkedList list = new LinkedList();
      list.Insert(23);
      list.Insert(15);
      list.Append(31);
      list.Append(13);
      list.Print();
    }
  }
}
