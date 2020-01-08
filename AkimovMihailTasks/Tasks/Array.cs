using System;

namespace AkimovMihailTasks.Tasks
{
    public class Array
    {

        public static void ArrayTask()
        {
            int N;
            Array array = new Array();

            Console.WriteLine("Enter general array dimension N:");
            N = Convert.ToInt32(Console.ReadLine());

            array.ArrayMain(N);
        }

        private void ArrayMain(int N)
        {
            int count = 1;
            int[][] jaggedArray = new int[N][];
            int arrayCount = 0;
            
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Enter array dimension " + count++ + ":");
                int N1 = Convert.ToInt32(Console.ReadLine());
                arrayCount += N1;
                jaggedArray[i] = new int[N1];
            }

            ArrayRand(jaggedArray);
            Console.WriteLine();
            
            BubbleSort(jaggedArray);
            Console.WriteLine();

            PrintArray(jaggedArray);
            Console.WriteLine();

            SortGeneral(jaggedArray, arrayCount);
            Console.WriteLine();

            PrintArray(jaggedArray);
            Console.WriteLine();
        }

        private void ArrayRand(int[][] items)
        {
            Random rnd = new Random();

            Console.Write("Jagged Array: ");
            Console.Write("{ ");
            for (int i = 0; i < items.Length; i++) 
            {
                Console.Write("{");
                for (int j = 0; j < items[i].Length; j++)
                {
                    items[i][j] = rnd.Next(0, 100);
                    Console.Write(items[i][j]);
                    Console.Write(",");
                }
                Console.Write("}, ");
            }
            Console.Write("}");
        }

        private void BubbleSort(int[][] items)
        {
            int temp;

            for (int k = 0; k < items.Length; k++)
            {
                for (int i = 0; i < items[k].Length - 1; i++)
                {
                    for (int j = i + 1; j < items[k].Length; j++)
                    {
                        if (items[k][i] > items[k][j])
                        {
                            temp = items[k][i];
                            items[k][i] = items[k][j];
                            items[k][j] = temp;
                        }
                    }
                }
            }
        }

        private void BubbleSort(int[] items)
        {
            int temp;

            for (int i = 0; i < items.Length - 1; i++)
            {
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i] > items[j])
                    {
                        temp = items[i];
                        items[i] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }

        private void SortGeneral(int[][] items, int arrayCount)
        {
            int[] tempArray = new int[arrayCount];
            int cout = 0;
            
                for (int i = 0; i < items.Length; i++)
                {
                    for (int j = 0; j < items[i].Length; j++)
                    {
                        tempArray[cout++] = items[i][j]; 
                    }
                }
            
            BubbleSort(tempArray);
            
            cout = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items[i].Length; j++)
                {
                    items[i][j] = tempArray[cout++];
                }
            }
        }

        private void PrintArray(int[][] items)
        {
            Console.Write("Sort jagged Array: ");
            Console.Write("{ ");
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write("{");
                for (int j = 0; j < items[i].Length; j++)
                {
                    Console.Write(items[i][j]);
                    Console.Write(",");
                }
                Console.Write("}, ");
            }
            Console.Write("}");
        }

    }
}
