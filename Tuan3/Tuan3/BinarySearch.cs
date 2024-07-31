using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    public class BinarySearch
    {
        public static int BinarySearchNonRecursive(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }

                if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1; // Trả về -1 nếu không tìm thấy target trong mảng
        }

        public static int BinarySearchRecursive(int[] arr, int target, int left, int right)
        {
            if (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    return BinarySearchRecursive(arr, target, mid + 1, right);
                }
                else
                {
                    return BinarySearchRecursive(arr, target, left, mid - 1);
                }
            }

            return -1; // Trả về -1 nếu không tìm thấy target trong mảng
        }

    }
}
