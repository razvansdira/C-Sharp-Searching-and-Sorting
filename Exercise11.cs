using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Searching_and_Sorting
{
    class Exercise11
    {
        static void Main(string[] args)
        {
            Selection_sort selection = new Selection_sort(8);
            selection.sort();
            Console.ReadLine();
        }
    }

    class Selection_sort
    {
        private int[] data;
        private static Random generator = new Random();

        public Selection_sort(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; i++)
                data[i] = generator.Next(20, 80);
        }

        public void sort()
        {
            Console.WriteLine(" Sorted array: ");
            display_array();
            int smallest;

            for(int i=0; i<data.Length-1; i++)
            {
                smallest = i;
                for(int index=i+1; index<data.Length; index++)
                {
                    if (data[index] < data[smallest])
                        smallest = index;
                }
                swap(i, smallest);
                display_array();
            }
        }

        public void swap(int first, int sec)
        {
            int x = data[first];
            data[first] = data[sec];
            data[sec] = x;
        }

        public void display_array()
        {
            foreach (var elem in data)
                Console.Write(elem + " ");
            Console.WriteLine();
        }
    }
}
