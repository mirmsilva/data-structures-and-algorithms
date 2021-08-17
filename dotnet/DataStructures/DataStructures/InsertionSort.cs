using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{

  //CHALLENGE 26
 public class InsertionSort
  {
    public static int[] InsertionSortArray(int[] arr)
    {
      for (int i = 1; i < arr.Length; i++)
      {
        int j = i - 1;
        int temp = arr[i];
        while (j >= 0 && temp < arr[j])
        {
          arr[j + 1] = arr[j];
          j = j - 1;
        }
        arr[j + 1] = temp;
      }
      return arr;
    }
  }
}
