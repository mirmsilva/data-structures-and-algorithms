using System;

namespace Challenge07
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] arr = { 80, 3, 6, 100 };
      int arr_size = arr.Length;
      int max_diff = 0;
      if (arr_size == 0 || arr_size == 1)
      {
        Console.WriteLine("no difference");
      }
      else
      {
        max_diff = arr[1] - arr[0];
        int i, j;
        for (i = 0; i < arr_size; i++)
        {
          for (j = i + 1; j < arr_size; j++)
          {
            if (arr[j] - arr[i] > max_diff)
              max_diff = -1;

            if (arr[j] - arr[i] > max_diff)
              max_diff = arr[j] - arr[i];
          }
        }
        Console.WriteLine(max_diff);
      }
    }





    //-----------------------------------------
    //int length = arr.Length;
    //int[] tempArray = new int[length - 1];
    //int maxDiff = -1;
    //for (int i = 0; i < length - 1; i++)
    //  tempArray[i] = arr[i + 1] - arr[i];
    //maxDiff = tempArray[0];

    //for (int j = 1; j < length - 1; j++)
    //{
    //  Console.WriteLine(tempArray[j]);
    //  if (tempArray[j - 1] > 0)
    //    tempArray[j] += tempArray[j - 1];

    //  if (maxDiff < tempArray[j])
    //    maxDiff = tempArray[j];


    //}
    //Console.WriteLine(maxDiff);
  }


  //--------COUNT THE DUPLICATES IN ARRAY---------------
  //public void DuplicateCount()
  //{
  //  int[] arr = { 1, 3, 4, 2, 3, 5, 6, 1 };
  //  int count = 0;
  //  for (int i = 0; i < arr.Length; i++)
  //  {
  //    for (int j = i + 1; j < arr.Length; j++)
  //    {
  //      if (arr[i] == arr[j])
  //      {
  //        count++;
  //        break;
  //      }
  //    }
  //  }
  //  Console.WriteLine(count);
  //}
}
