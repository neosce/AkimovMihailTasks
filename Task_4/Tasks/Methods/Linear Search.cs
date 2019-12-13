using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Task_4.Tasks.Methods
{

    public delegate bool Condition(int value);
    public delegate bool Operation(int value);

    public class Linear_Search
    {

        private static bool IsPositive(int value)
        {
            return value > 0;
        }

        public static Operation operation = delegate (int value)
        {
            return value > 0;
        };

        public static Condition conditionLambda = (int value) => value > 0;

        public static void ToSearch(int[] items, int countReplay)
        {
            Stopwatch stopwatch = new Stopwatch();
            
            List<int> countElements = new List<int>();
            List<long> averageSearch = new List<long>();
            
            stopwatch.Reset();
            stopwatch.Start();
            
            for (int i = 0; i < countReplay; i++)
            {
                
                for (int j = 0; j < items.Length; j++)
                {
                    if (items[j] > 0)
                    {
                        countElements.Add(items[j]);
                    }
                }
                averageSearch.Add(stopwatch.ElapsedMilliseconds);
            }
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"1 - Method\nNumber of array positive : {countElements.Count} for replay {countReplay}\nmSec for average: {averageSearch.Average()}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ToSearchCondition(int[] items, int countReplay)
        {
            Stopwatch stopwatch = new Stopwatch();

            List<int> countElements = new List<int>();
            List<long> averageSearch = new List<long>();
            Condition condition = new Condition(IsPositive);
            
            stopwatch.Reset();
            stopwatch.Start();
            
            for (int i = 0; i < countReplay; i++)
            {

                for (int j = 0; j < items.Length; j++)
                {
                    if (condition(items[j]))
                    {
                        countElements.Add(items[j]);
                    }
                }
                averageSearch.Add(stopwatch.ElapsedMilliseconds);
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"2 - Method\nNumber of array positive : {countElements.Count} for replay {countReplay}\nmSec for average: {averageSearch.Average()}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ToSearchAnonymous(int[] items, int countReplay)
        {
            Stopwatch stopwatch = new Stopwatch();

            List<int> countElements = new List<int>();
            List<long> averageSearch = new List<long>();
            Condition condition = new Condition(IsPositive);


            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < countReplay; i++)
            {

                for (int j = 0; j < items.Length; j++)
                {
                    if (operation(items[j]))
                    {
                        countElements.Add(items[j]);
                    }
                }
                averageSearch.Add(stopwatch.ElapsedMilliseconds);
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"3 - Method\nNumber of array positive : {countElements.Count} for replay {countReplay}\nmSec for average: {averageSearch.Average()}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ToSearchLambda(int[] items, int countReplay)
        {
            Stopwatch stopwatch = new Stopwatch();

            List<int> countElements = new List<int>();
            List<long> averageSearch = new List<long>();

            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < countReplay; i++)
            {

                for (int j = 0; j < items.Length; j++)
                {
                    if (conditionLambda(items[j]))
                    {
                        countElements.Add(items[j]);
                    }
                }
                averageSearch.Add(stopwatch.ElapsedMilliseconds);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"4 - Method\nNumber of array positive : {countElements.Count} for replay {countReplay}\nmSec for average: {averageSearch.Average()}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ToSearchLINQ(int[] items, int countReplay)
        {
            Stopwatch stopwatch = new Stopwatch();

            List<int> countElements = new List<int>();
            List<long> averageSearch = new List<long>();

            stopwatch.Reset();
            stopwatch.Start();

            for (int i = 0; i < countReplay; i++)
            {
                countElements = (from el in items
                                where el > 0
                                select el).ToList();

                averageSearch.Add(stopwatch.ElapsedMilliseconds);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"5 - Method\nNumber of array positive : {countElements.Count} for replay {countReplay}\nmSec for average: {averageSearch.Average()}");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }
}
