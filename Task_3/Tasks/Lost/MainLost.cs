using System;
using System.Collections.Generic;

namespace Task_3.Tasks.Lost
{
    public class MainLost
    {

        public static void MLost()
        {

            Console.WriteLine("LOST");

            try
            {
                Console.Write("Enter number people: ");
                var people = int.Parse(Console.ReadLine());

                AlgorithmLost(people);

            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input...");
            }

        }

        private static void AlgorithmLost(int N)
        {
            int current = 0;
            List<int> people = new List<int>();

            Console.Write("List: [");
            for (int i = 1; i <= N; i++)
            {
                people.Add(i);
                Console.Write($"{people[current]}, ");
                current++;

            }
            Console.WriteLine("]");

            do
            {
                Console.Write("Delete: [");
                for (int i = 1; i < people.Count; i++)
                {
                    Console.Write($"{people[i]}, ");
                    people.RemoveAt(i);
                }
                Console.WriteLine("]");
                Console.WriteLine($"List count: {people.Count}");

            } while (people.Count != 1);

        }

    }
}
