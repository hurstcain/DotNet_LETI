using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new LinkedList<int>();

            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(10);
            linkedList.Add(1);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            linkedList.Remove(1);

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            linkedList.Reverse();
   
            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
