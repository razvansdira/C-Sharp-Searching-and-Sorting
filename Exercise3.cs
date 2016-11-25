using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Searching_and_Sorting
{
    class Exercise3
    {
        static void Main(String[] args)
        {
            int x;
            int[] a = { 3, 0, 2, 5, -1, 4, 1 };
            Console.Write(" Originally array: ");
            foreach(int aa in a)
                Console.Write(aa + " ");
            for(int p=0; p<=a.Length-2; p++)
            {
                for(int i=0; i<=a.Length-2; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        x = a[i + 1];
                        a[i + 1] = a[i];
                        a[i] = x;
                    }
                }
            }
            Console.Write("\n    Sorted array: ");
            foreach (int aa in a)
                Console.Write(aa + " ");
            Console.ReadLine();
        }
    }
}
