using System;
using System.Collections.Generic;
using Xunit;
using DataStructures;


namespace DataStructureTests
{
  public class UnitTest1
  {
    //------------CODE CHALLENGE 27-------------
    [Fact]
    public void SingleValue()
    {
      int[] arr = { 1 };

      Assert.Equal(arr, Mergesort(arr));
    }

    [Fact]
    public void PropReturnTest()
    {
      int[] arr = { 4, 3, 2, 1 };
      int[] bar = { 1, 2, 3, 4 };

      Assert.Equal(bar, Mergesort(arr));
    }
    [Fact]
    public void ReturnSameArrTest()
    {
      int[] arr = { 4, 3, 2, 1 };
      int[] bar = { 4, 3, 2, 1 };
      Assert.Equal(bar, Mergesort(arr));
    }

    //------------CODE CHALLENGE 26-------------
    //TEST 1
    [Fact]
    public void CanSortArray()
    {
      
      int[] arr = { 2, 6, 8, 7, 1 };
      int[] sorted = InsertionSort.InsertionSortArray(arr);

      Assert.Equal(1, sorted[0]);
      Assert.Equal(2, sorted[1]);
      Assert.Equal(6, sorted[2]);
      Assert.Equal(7, sorted[3]);
      Assert.Equal(8, sorted[4]);
    }

    //TEST 2
    [Fact]
    public void CanSortWithNegatives()
    {
      int[] arr = { 2, 6, -8, 7, -1 };
      int[] sorted = InsertionSort.InsertionSortArray(arr);

      Assert.Equal(-8, sorted[0]);
      Assert.Equal(-1, sorted[1]);
      Assert.Equal(2, sorted[2]);
      Assert.Equal(6, sorted[3]);
      Assert.Equal(7, sorted[4]);
    }

    ////------------CODE CHALLENGE 18-------------
    //[Fact]
    //public void Test1()
    //{
    //  KaryTree<int> k = new KaryTree<int>(10);

    //  k.Root.Value = 10;
    //  k.Root.Children.Add(new Node<int>(10));
    //  k.Root.Children.Add(new Node<int>(3));
    //  k.Root.Children.Add(new Node<int>(15));

    //  KaryTree<string> res = k.FizzBuzz(k);

    //  Assert.Equal("buzz", res.Root.Value);
    //}
    //[Fact]
    //public void TestPeek()
    //{
    //  PseudoQueue<int> one = new PseudoQueue<int>();
    //  one.stackOne.Push(5);
    //  one.stackOne.Push(2);
    //  one.stackOne.Push(7);
    //  one.Enqueue(4);

    //  PseudoQueue<int> two = new PseudoQueue<int>();

    //  Assert.False(one.stackOne.IsEmpty());
    //}

    ////------------CODE CHALLENGE 15-------------
    ////EMPTY TREE TEST
    //[Fact]
    //public void CanMakeEmptyTree()
    //{
    //  BinaryTree<int> tree = new BinaryTree<int>();
    //  tree.Root = new Node<int>(1);
    //  Assert.Equal(1, tree.Root.Value);
    //}

    ////ADD NODES TEST
    //[Fact]
    //public void CanAddLeftAndRightNode()
    //{
    //  BinaryTree<int> tree = new BinaryTree<int>();
    //  tree.Root = new Node<int>(1);
    //  tree.Root.Left = new Node<int>(6);
    //  tree.Root.Right = new Node<int>(10);
    //  Assert.Equal(6, tree.Root.Left.Value);
    //  Assert.Equal(10, tree.Root.Right.Value);
    //}
    ////------------CODE CHALLENGE 10-------------
    ////STACKS
    //[Fact]
    //public void StackIsOrIsNotEmptyAndCanPush()
    //{
    //  DataStructures.Stack<int> stack = new DataStructures.Stack<int>();
    //  Assert.True(stack.IsEmpty());
    //  stack.Push(1);
    //  Assert.False(stack.IsEmpty());
    //}

    //[Fact]
    //public void StackCanPop()
    //{
    //  DataStructures.Stack<int>stack = new DataStructures.Stack<int>();
    //  stack.Push(5);
    //  stack.Push(10);
    //  Assert.Equal(10, stack.Pop());
    //}

    ////QUEUE
    //[Fact]
    //public void CannotPeekOrDequeueEmptyQueue()
    //{
    //  DataStructures.Queue<int> q = new DataStructures.Queue<int>();
    //  Assert.Throws<NullReferenceException>(() => q.Peek());
    //}
  }
}
