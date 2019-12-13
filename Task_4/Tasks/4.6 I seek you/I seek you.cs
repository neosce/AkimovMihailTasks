using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_4.Tasks.Methods;

namespace Task_4.Tasks._4._6_I_seek_you
{

    public delegate bool ActionFunc(int i, int j);

    public class I_seek_you
    {
        private readonly Func<int, int, bool> compare = delegate (int i, int j)
        {
            return i > j;
        };
        private static int SizeArray()
        {
            Random random = new Random();
            var elements = random.Next(15000,30000);
            return elements;
        }

        public static void ISeekYouMain()
        {
            Console.WriteLine("I seek you".ToUpper());

            Stopwatch stopwatch = new Stopwatch();
            
            // Stuff array
            int[] array = new int[SizeArray()];
            Methods.Array_Random array_Random = new Methods.Array_Random();
            array_Random.ArrayRandNoPrint(array);

            var countReplay = default(int);
            try
            {
                Console.WriteLine("Input number of replay: ");
                countReplay = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Input error...");
            }

            try
            {
                Linear_Search.ToSearch(array, countReplay);
                Linear_Search.ToSearchCondition(array, countReplay);
                Linear_Search.ToSearchAnonymous(array, countReplay);
                Linear_Search.ToSearchLambda(array, countReplay);
                Linear_Search.ToSearchLINQ(array, countReplay);
            }
            catch (Exception)
            {
                Console.WriteLine("Algorithm crash...");
            }



        }

    }
}
