using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Searching_and_Sorting
{
    class Exercise4
    {
        public static void Main(string[] args)
        {
            int[] array = new int[10] { 2, 5, -4, 11, 0, 8, 22, 67, 51, 6 };

            Console.Write(" Original array: ");
            foreach (int aa in array)
                Console.Write(aa + " ");

            int[] sortedArray = new int[array.Length];

            int min = array[0];
            int max = array[0];
            for(int i=1; i<array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                else if (array[i] > max)
                    max = array[i];
            }
            int[] crt = new int[max - min + 1];

            for (int i = 0; i < array.Length; i++)
                crt[array[i] - min]++;

            crt[0]--;
            for (int i = 1; i < crt.Length; i++)
                crt[i] += crt[i - 1];

            for (int i = array.Length - 1; i >= 0; i--)
                sortedArray[crt[array[i] - min]--] = array[i];

            Console.Write("\n  Sorted array; ");
            foreach (int aa in sortedArray)
                Console.Write(aa + " ");
            Console.ReadLine();
        }
    }
}
