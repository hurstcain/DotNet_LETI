using System;

namespace InsertionSort
{
    class Program
    {
        // Функция реализует сортировку вставками
        static int[] InsertionSort(int[] input_arr)
        {
            for (int i = 0; i < input_arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (input_arr[j - 1] > input_arr[j])
                    {
                        int temp = input_arr[j - 1];
                        input_arr[j - 1] = input_arr[j];
                        input_arr[j] = temp;
                    }
                }
            }

            return input_arr;
        }

        static void Main()
        {
            int[] arr = new int[10] { 0, 30, -40, 4, 22, 67, -10, 2, 2, -1 };

            Console.WriteLine("Массив до сортировки :");
            foreach (int i in arr)
            {
                Console.Write(i.ToString() + "  ");
            }

            InsertionSort(arr);
            Console.WriteLine("\nМассив после сортировки :");
            foreach (int i in arr)
            {
                Console.Write(i.ToString() + "  ");
            }
        }
    }
}
