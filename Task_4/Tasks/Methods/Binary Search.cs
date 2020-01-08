using System;

namespace Task_4.Tasks.Methods
{
    public class Binary_Search
    {

        public static void BinarySearchMain()
        {
            Console.WriteLine("Binary search (recursive implementation)");
            Console.Write("Enter array elements: ");

            Random random = new Random();
            var elements = random.Next(5, 15);
            int[] array = new int[elements];

            Array_Random array_Random = new Array_Random();
            array_Random.ArrayRand(array);

            PrintArray<int> printArray = new PrintArray<int>();
            printArray.Print_Array(array, "Array random");

            Array.Sort(array);
            Console.WriteLine("Sort array: {0}", string.Join(", ", array));

            while (true)
            {
                Console.Write("Enter the search value or -777 to exit: ");
                var searchedValue = Convert.ToInt32(Console.ReadLine());
                if (searchedValue == -777)
                {
                    break;
                }

                var searchResult = BinarySearch(array, searchedValue, 0, array.Length - 1);
                if (searchResult < 0)
                {
                    Console.WriteLine("Element with value {0} not found", searchedValue);
                }
                else
                {
                    Console.WriteLine("Item found. The index of an element with a value of {0} is {1}", searchedValue, searchResult);
                }
            }

        }

        private static int BinarySearch(int[] array, int searchedValue, int first, int last)
        {
            // borders converge
            if (first > last)
            {
                //value not found
                return -1;
            }

            // average subarray index
            var middle = (first + last) / 2;
            // value in the middle of the subarray
            var middleValue = array[middle];

            if (middleValue == searchedValue)
            {
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    // recursive search call for left subarray
                    return BinarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    // recursive search call for right subarray
                    return BinarySearch(array, searchedValue, middle + 1, last);
                }
            }
        }

    }
}
