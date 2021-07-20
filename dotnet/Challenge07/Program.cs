using System;

namespace Challenge07
{
    class Program
    {
        static void Main(string[] args)
        {
   
        LinkedList OurList = new LinkedList { };
        OurList.Insert(2);
        OurList.Insert(7);
        OurList.Insert(9);
        OurList.Insert(3);
        OurList.Append(4);
        OurList.Print();
        OurList.returnNodeValue(7);
        }
    }
}
