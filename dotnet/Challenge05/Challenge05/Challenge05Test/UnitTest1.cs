using System;
using Xunit;
using Challenge05;

namespace Challenge05Test
{
  public class UnitTest1
  {
    [Fact]
    public void CanPrintEmptyList()
    {
      // syntax for instantiating an empty list
      //Will check that HEAD is null
      LinkedList OurList = new LinkedList();

      //Null is a Keyword
      Assert.Null(OurList.Head);

    }
    //Will Test that we can insert
    [Fact]
    public void CanInsert()
    {
      LinkedList OurList = new LinkedList();
      OurList.Insert(5);
      Assert.Equal(5, OurList.Head.Value);

    }
  }
}
