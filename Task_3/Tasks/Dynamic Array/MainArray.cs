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
            
            // FOR TEST!
            //Console.WriteLine(dArray[0]);
            //Console.WriteLine(dArray[1]);
            //Console.WriteLine(dArray[2]);
            //Console.WriteLine(dArray[3]);
            //Console.WriteLine(dArray[4]);
            //Console.WriteLine(dArray[5]);
            //Console.WriteLine(dArray[6]);
            //Console.WriteLine(dArray[7]);
            //Console.WriteLine(dArray[8]);
            //Console.WriteLine(dArray[9]);
            //Console.WriteLine(dArray[10]);
            //
            
            foreach (var item in addArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Count = " + addArray.Count());

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

            DynamicArray<string> input = new DynamicArray<string>() {"1", "2", "3"};
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
            DynamicArray<string> toArray = input.ToArray() as DynamicArray<string>;
            Console.WriteLine("toArray");
            foreach (var item in toArray)
            {
                Console.WriteLine(item);
            }


        }

    }
}
