using System;
using System.Threading;

namespace Task_4.Tasks._4._3_Sorting_Unit
{
    public delegate void EventThreadEnd();

    public class Sorting_Unit
    {
        private static int[] array;
        public static event EventThreadEnd EventSortEnd = null;

        public static void InvokeEvent()
        {
            EventSortEnd.Invoke();
        }

        static private void HandlerStop()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nSort Stop!");
        }

        private static void FuncTheard()
        {
            Console.WriteLine("ID Secondary thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Random random = new Random();
            var elements = random.Next(5, 15);
            array = new int[elements];

            Methods.Array_Random array_Random = new Methods.Array_Random();
            array_Random.ArrayRand(array);

            Methods.Bubble_Sort bubble_Sort = new Methods.Bubble_Sort();
            bubble_Sort.BubbleSortMain(array);
            Sorting_Unit sorting_Unit = new Sorting_Unit();
            EventSortEnd += new EventThreadEnd(HandlerStop);
            InvokeEvent();
            EventSortEnd -= new EventThreadEnd(HandlerStop);

            Thread.Sleep(300); // Rest thread...

            Console.ForegroundColor = ConsoleColor.Gray;
            
            Console.WriteLine("\nSecondary flow ended");
        }

        private static bool InputQ()
        {
            try
            {
                Console.WriteLine("Block thread ?\n");
                Console.Write("Input yes/no :");
                var sync = Console.ReadLine();
                if (sync == "yes")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Input error...");
                return false;
            }
        }

        public static void SortingUnitMain()
        {
            bool j = InputQ();
            
            // Create new Theard
            var thread = new Thread(new ThreadStart(FuncTheard));
            
            Console.WriteLine("ID Primary thread: {0}\n", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Start new thread...");

            thread.Start();
            Console.WriteLine(Thread.CurrentThread.GetHashCode());

            if (j)
            {
                Console.WriteLine("Thread block");
                thread.Join(); //TODO Bind to a button
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Thread not blocked");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            
            Console.ForegroundColor = ConsoleColor.Green;

            Thread.Sleep(300);
            Methods.PrintArray<int> printArray = new Methods.PrintArray<int>();
            printArray.Print_Array(array, "Thread sort");
            // Событие

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPrimary thread ended!");
        }

    }
}