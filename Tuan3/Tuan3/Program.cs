using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //Tính tổng mảng từ 1..n, theo phương pháp chia để trị
            Console.WriteLine("1) Tính tổng mảng từ 1..n, theo phương pháp chia để trị");
            Console.WriteLine("Không đệ quy:");
            int n1a = 5;
            int tong1a = TongMang1_n.TongMang(1, n1a);
            Console.WriteLine("Tổng của mảng từ 1 đến " + n1a + " là: " + tong1a);

            Console.WriteLine("Đệ quy:");
            int n1b = 5; 
            int[] arr1b = new int[n1b];
            for (int i = 0; i < n1b; i++)
            {
                arr1b[i] = i + 1;
            }

            int tong1b = TongMang1_n.TongMang2(arr1b, 0, n1b - 1);
            Console.WriteLine("Tổng của mảng từ 1 đến " + n1b + " là: " + tong1b);

            //QuickSort
            Console.WriteLine("\n 2) QuickSort");
            int[] arr2 = { 6, 3, 8, 5, 2, 7 };
            int n2 = arr2.Length;

            Console.WriteLine("Mảng trước khi sắp xếp:");
            foreach (var num in arr2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            QuickSort.Sort(arr2, 0, n2 - 1);

            Console.WriteLine("Mảng sau khi sắp xếp:");
            foreach (var num in arr2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //BinarySearch
            Console.WriteLine("\n3) BinarySearch");
            
            Console.WriteLine("Không đệ quy:");
            int[] arr3a = { 2, 5, 7, 9, 12, 15, 19, 22, 25 };
            int target3a = 15;
            foreach (var num in arr3a)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            int result3a = BinarySearch.BinarySearchNonRecursive(arr3a, target3a);

            if (result3a != -1)
            {
                Console.WriteLine("Phần tử {0} được tìm thấy tại vị trí {1}.", target3a, result3a);
            }
            else
            {
                Console.WriteLine("Không tìm thấy phần tử {0} trong mảng.", target3a);
            }

            Console.WriteLine("Đệ quy:");
            int[] arr3b = { 2, 5, 7, 9, 12, 15, 19, 22, 25 };
            int target3b = 15;
            foreach (var num in arr3b)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
            int result3b = BinarySearch.BinarySearchRecursive(arr3b, target3b, 0, arr3b.Length - 1);

            if (result3b != -1)
            {
                Console.WriteLine("Phần tử {0} được tìm thấy tại vị trí {1}.", target3b, result3b);
            }
            else
            {
                Console.WriteLine("Không tìm thấy phần tử {0} trong mảng.", target3b);
            }

            Console.ReadKey();
        }
    }
}
