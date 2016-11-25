using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Searching_and_Sorting
{
    class Exercise5
    {
        public static void Main(string[] args)
        {
            int[] nr = new int[] { 2, 5, 4, 11, 0, 18, 82, 6, 50, 8 };

            Console.Write(" Original array: ");
            printArray(nr);

            heapSort(nr);

            Console.Write("\n   Sorted array: ");
            printArray(nr);
            Console.ReadLine();
        }

        private static void heapSort<T>(T[] array) where T : IComparable<T>
        {
            int heap = array.Length;

            buildMaxHeap(array);

            for (int i = heap - 1; i >= 1; i--)
            {
                swap(array, i, 0);
                heap--;
                sink(array, heap, 0);
            }
        }

        private static void buildMaxHeap<T>(T[] array) where T : IComparable<T>
        {
            int heap = array.Length;

            for (int i = (heap / 2) - 1; i >= 0; i--)
                sink(array, heap, i);
        }

        private static void sink<T>(T[] array, int heap, int toSink) where T : IComparable<T>
        {
            if (getLeft(toSink) >= heap)
                return;

            int largestKid;
            bool leftIsLargest;

            if (getRight(toSink) >= heap || array[getRight(toSink)].CompareTo(array[getLeft(toSink)]) < 0)
            {
                largestKid = getLeft(toSink);
                leftIsLargest = true;
            }
            else
            {
                largestKid = getRight(toSink);
                leftIsLargest = false;
            }

            if (array[largestKid].CompareTo(array[toSink]) > 0)
            {
                swap(array, toSink, largestKid);

                if (leftIsLargest)
                    sink(array, heap, getLeft(toSink));

                else
                    sink(array, heap, getRight(toSink));
            }

        }

        private static void swap<T>(T[] array, int pos0, int pos1)
        {
            T tmpVal = array[pos0];
            array[pos0] = array[pos1];
            array[pos1] = tmpVal;
        }

        private static int getLeft(int parentPos)
        {
            return (2 * (parentPos + 1)) - 1;
        }

        private static int getRight(int parentPos)
        {
            return 2 * (parentPos + 1);
        }

        private static void printArray<T>(T[] array)
        {
            foreach (T t in array)
                Console.Write(' ' + t.ToString() + ' ');
        }
    }
}
