using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class Search
    {
        public static int BinarySearch_R(int key, int[] array, int low, int high, bool ascend)
        {
            if (low > high) return -1;
            int mid = (low + high) / 2;
            if (key == array[mid])
            {
                return mid;
            }
            if (ascend)
            {
                if (key < array[mid])
                {
                    return BinarySearch_R(key, array, low, mid - 1, ascend);
                }
                else
                {
                    return BinarySearch_R(key, array, mid + 1, high, ascend);
                }
            }
            else
            {
                if (key > array[mid])
                {
                    return BinarySearch_R(key, array, low, mid - 1, ascend);
                }
                else
                {
                    return BinarySearch_R(key, array, mid + 1, high, ascend);
                }
            }
        }
    }
}