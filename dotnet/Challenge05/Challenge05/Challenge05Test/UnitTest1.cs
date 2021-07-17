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
    [Fact]
    public void HeadPointsToFirst()
    {
      LinkedList OurList = new LinkedList();
      OurList.Insert(7);
      OurList.Insert(8);
      Assert.Equal(8, OurList.Head.Value);
    }
    [Fact]
    public void TrueIfNameExists()
    {
      LinkedList OurList = new LinkedList();
      OurList.Insert(3);
      OurList.Insert(5);

      Assert.True(OurList.Includes(5));
    }
    [Fact]
    public void FalseIfNameDoesNotExists()
    {
      LinkedList OurList = new LinkedList();
      OurList.Insert(3);
      OurList.Insert(5);

      Assert.False(OurList.Includes(4));
    }
    [Fact]
    public void ReturnAllValues()
    {
      LinkedList OurList = new LinkedList();
      OurList.Insert(2);
      OurList.Insert(7);
      Assert.Equal("(7) =>(2) =>", OurList.Print());
    }
  }
}
