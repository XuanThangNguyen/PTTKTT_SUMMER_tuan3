using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    public class TongMang1_n
    {
        public static int TongMang(int left, int right)
        {
            if (left == right)
            {
                return left;
            }
            else
            {
                int mid = (left + right) / 2;
                return TongMang(left, mid) + TongMang(mid + 1, right);
            }
        }

        public static int TongMang2(int[] arr, int left, int right)
        {
            if (left == right)
            {
                return arr[left];
            }
            else
            {
                int mid = (left + right) / 2;
                int leftSum = TongMang2(arr, left, mid);
                int rightSum = TongMang2(arr, mid + 1, right);
                return leftSum + rightSum;
            }
        }
    }
}
