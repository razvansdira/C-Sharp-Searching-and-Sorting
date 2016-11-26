using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Searching_and_Sorting
{
    class Exercise10
    {
        static void Main(String[] args)
        {
            int[] arr = new int[]
                {2,4,11,0,45,18,65,99,28,-8};
            Console.Write(" Original array: ");
            foreach (var item in arr)
                Console.Write(" " + item);
            sort(arr);
            Console.Write("\n  Sorted array: ");
            foreach (var item in arr)
                Console.Write(" " + item);
            Console.ReadLine();
        }
        static void sort(int[] arr)
        {
            int x, y;
            int[] abc = new int[arr.Length];
            for(int shift=31; shift>-1; --shift)
            {
                y = 0;
                for(x=0; x < arr.Length; ++x)
                {
                    bool move = (arr[x] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[x - y] = arr[x];
                    else
                        abc[y++] = arr[x];
                }
                Array.Copy(abc, 0, arr, arr.Length - y, y);
            }
        }
    }
}
