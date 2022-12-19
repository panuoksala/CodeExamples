using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public static class BubbleSort
    {
        public static void Sort()
        {
            Console.WriteLine("Bubble Sort!");
            int[] array = { 1, 4, 2, 5, -2, 3 };

            Console.WriteLine($"Initial array is: {string.Join(',', array)}");

            for (int j = 0; j < array.Length; j++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        // Swap by using temp variable
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }

            Console.WriteLine($"After sort: {string.Join(',', array)}");
        }
    }
}
