using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3.Tasks.Dynamic_Array
{
    public class MainArray
    {
        public static void DynamicArrayTest()
        {
            Console.WriteLine("Dynamic Array".ToUpper());

            DynamicArray<int> addArray = new DynamicArray<int>();
            
            addArray.Add(default);
            addArray.Add(20);
            addArray.Add(30);
            addArray.Add(50);
            addArray.Add(60);
            addArray.Add(70);
            addArray.Add(80);
            addArray.Add(90);
            addArray.Add(100);
            addArray.Add(110);
            addArray.Add(120);
            addArray.Add(130);
            
            foreach (var item in addArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count = " + addArray.Count());

            Console.WriteLine("Ctor IEnumerable<T>");
            string[] ctor = { "Brachiosaurus", "Amargasaurus", "Mamenchisaurus" };
            DynamicArray<string> ctorTest = new DynamicArray<string>(ctor);
            Console.WriteLine("\nCapacity: {0}", ctorTest.Capacity);
            Console.WriteLine();
            foreach (var item in ctorTest)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("AddRange");
            DynamicArray<string> addRangeArray = new DynamicArray<string>(ctor);
            addRangeArray.AddRange(ctor);
            foreach (var item in addRangeArray)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("Clone");
            var mas = new int[3] { 1, 2, 3 };
            int[] mas2 = mas.Clone() as int[];
            
            mas2[0] = 20;

            Console.WriteLine("Array 1:");
            foreach (var item in mas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Array 2:");
            foreach (var item in mas2)
            {
                Console.WriteLine(item);
            }


            //Console.WriteLine("ToArray: ");
            //DynamicArray<string> input = new DynamicArray<string>() {"1", "2", "3"};
            //foreach (var item in input)
            //{
            //    Console.WriteLine(item);
            //}
            //DynamicArray<string> toArray = input.ToArray() as DynamicArray<string>;
            //Console.WriteLine("toArray");
            //foreach (var item in toArray)
            //{
            //    Console.WriteLine(item);
            //}


        }

    }
}
