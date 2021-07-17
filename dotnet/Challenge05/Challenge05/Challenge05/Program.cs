using System;

namespace Challenge05
{
  class Program
  {
    static void Main(string[] args)
    {
      LinkedList OurList = new LinkedList { };
      OurList.Insert(2);
      OurList.Insert(7);
      OurList.Print();
    }
  }
}
