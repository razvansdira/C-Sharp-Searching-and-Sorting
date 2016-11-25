using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Searching_and_Sorting
{
    class Exercise2
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2, 1, 4, 8 };
            bogo_sort(list, true, 5);
            Console.ReadKey();
        }
        static void bogo_sort(List<int> list, bool announce, int delay)
        {
            int it = 0;
            while (!isSorted(list))
            {
                if (announce)
                    print_iteration(list, it);
                if (delay != 0)
                    System.Threading.Thread.Sleep(Math.Abs(delay));
                list = remap(list);
                it++;
            }
            print_iteration(list, it);
            Console.Write("Bogo sort completed after {0} iterations.", it);
        }

        static void print_iteration(List<int> list, int it)
        {
            Console.Write("Bogo sort iteration {0} : ", it);
            for(int i=0; i<list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        static bool isSorted(List<int> list)
        {
            for(int i=0; i<list.Count-1; i++)
            {
                if (list[i] > list[i + 1])
                    return false;
            }
            return true;
        }

        static List<int> remap(List<int> list)
        {
            int temp;
            List<int> newList = new List<int>();
            Random r = new Random();

            while (list.Count > 0)
            {
                temp = (int)r.Next(list.Count);
                newList.Add(list[temp]);
                list.RemoveAt(temp);
            }
            return newList;
        }
    }
}
