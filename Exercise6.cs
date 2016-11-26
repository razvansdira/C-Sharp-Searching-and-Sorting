using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Searching_and_Sorting
{
    class Exercise6
    {
        static void Main (string[] args)
        {
            int[] nr = new int[10] { 2, 5, 4, 11, 8, 44, 69, 51, 22, -9 };
            Console.Write(" Original array: ");
            print(nr);
            Console.Write("\n  Sorted array: ");
            print(insertionSort(nr));
            Console.ReadLine();
        }

        static int[] insertionSort(int[] inArr)
        {
            for(int i=0; i<inArr.Length-1; i++)
            {
                for(int j=i+1; j>0; j--)
                {
                    if (inArr[j - 1] > inArr[j])
                    {
                        int x = inArr[j - 1];
                        inArr[j - 1] = inArr[j];
                        inArr[j] = x;
                    }
                }
            }
            return inArr;
        }

        public static void print(int[] arr)
        {
            foreach (int i in arr)
                Console.Write(i.ToString() + " ");
        }

        public static int[] insert(int[] inArr)
        {
            for(int i=0; i<inArr.Length-1; i++)
            {
                int j;
                var insert = inArr[i];
                for(j=i; j>0; j--)
                {
                    if (inArr[j - 1] > insert)
                        inArr[j] = inArr[j - 1];
                }
                inArr[j] = insert;
            }
            return inArr;
        }
    }
}
