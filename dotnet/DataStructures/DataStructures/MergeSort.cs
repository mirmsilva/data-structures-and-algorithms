using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
  class MergeSort
  {
    public static int[] Mergesort(int[] arr)
    {
      int length = arr.Length;
      int mid = length / 2;
      int[] left;
      int[] right;
      int[] results = new int[length];

      if (length <= 1)
      {
        return arr;
      }
      left = new int[mid];
      if (length % 2 == 0)
      {
        right = new int[mid];
      }
      else
      {
        right = new int[mid + 1];
      }
      for (int i = 0; i < mid; i++)
      {
        left[i] = arr[i];
      }
      int x = 0;
      for (int k = mid; k < length; k++)
      {
        right[x] = arr[k];
        x++;
      }

      left = Mergesort(left);
      right = Mergesort(right);

      results = Merge(left, right);
      return results;
    }
    private static int[] Merge(int[] left, int[] right)
    {

      int i = 0;
      int j = 0;
      int k = 0;
      int[] results = new int[left.Length + right.Length];

      while (i < left.Length || j < right.Length)
      {
        if (i < left.Length && j < right.Length)
        {
          if (left[i] <= right[j])
          {
            results[k] = left[i];
            i++;
            k++;
          }
          else
          {
            results[k] = right[j];
            j++;
            k++;
          }
        }
        else if (i < left.Length)
        {
          results[k] = left[i];
          i++;
          k++;
        }
        else if (j < right.Length)
        {
          results[k] = right[j];
          j++;
          k++;
        }

      }
      return results;
    }
  }
}
