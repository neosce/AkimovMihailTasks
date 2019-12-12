using System;

namespace Task_4.Tasks.Methods
{
    public class PrintArray<T>
    {
        public void Print_Array(T[] items, string NameArray)
        {
            Console.Write($"\n{NameArray}: ");
            Console.Write("{ ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i]);
                Console.Write(",");
            }
            Console.Write("}\n");
        }
    }
}
