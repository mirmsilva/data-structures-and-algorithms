using System;
using System.Collections.Generic;
using Xunit;
using DataStructures;


namespace DataStructureTests
{
  public class UnitTest1
  {
    [Fact]
    public void TestPseudoQueue()
    {
      PseudoQueue<int> one = new PseudoQueue<int>();
      one.stackOne.Push(5);
      one.stackOne.Push(2);
      one.stackOne.Push(7);
      one.Enqueue(4);

      PseudoQueue<int> two = new PseudoQueue<int>();

      Assert.Equal(4, one.stackOne.Pop().Value);
      

    }
  }
}
