using System;
using System.Collections.Generic;
using Xunit;
using DataStructures;


namespace DataStructureTests
{
  public class UnitTest1
  {
    //CODE CHALLENGE 18: KARY TREE TEST #1
    [Fact]
    public void Test1()
    {
      KaryTree<int> k = new KaryTree<int>(10);

      k.Root.Value = 10;
      k.Root.Children.Add(new Node<int>(10));
      k.Root.Children.Add(new Node<int>(3));
      k.Root.Children.Add(new Node<int>(15));

      KaryTree<string> res = k.FizzBuzz(k);

      Assert.Equal("buzz", res.Root.Value);
    }
    [Fact]
    public void TestPeek()
    {
      PseudoQueue<int> one = new PseudoQueue<int>();
      one.stackOne.Push(5);
      one.stackOne.Push(2);
      one.stackOne.Push(7);
      one.Enqueue(4);

      PseudoQueue<int> two = new PseudoQueue<int>();

      Assert.False(one.stackOne.IsEmpty());
    }
    //EMPTY TREE TEST
    [Fact]
    public void CanMakeEmptyTree()
    {
      BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new Node<int>(1);
      Assert.Equal(1, tree.Root.Value);
    }

    //ADD NODES TEST
    [Fact]
    public void CanAddLeftAndRightNode()
    {
      BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new Node<int>(1);
      tree.Root.Left = new Node<int>(6);
      tree.Root.Right = new Node<int>(10);
      Assert.Equal(6, tree.Root.Left.Value);
      Assert.Equal(10, tree.Root.Right.Value);
    }
  }
}
