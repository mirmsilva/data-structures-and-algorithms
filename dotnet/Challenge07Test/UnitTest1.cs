using System;
using Xunit;
using Challenge07;

namespace Challenge07Test
{
  public class UnitTest1
  {
    [Fact]
    // return zero is k is greater than length of link list
    public void KGreaterThanLength()
    {
      LinkedList OurList = new LinkedList();
      OurList.Insert(4);
      OurList.Append(6);
      OurList.Append(3);

      Assert.Equal(0, OurList.returnNodeValue(5));
    }
    [Fact]
    public void KEqualToLength()
    {
      LinkedList OurList = new LinkedList();
      OurList.Insert(4);
      OurList.Append(6);
      OurList.Append(3);

      Assert.Equal(4, OurList.returnNodeValue(2));
    }
  }
}
