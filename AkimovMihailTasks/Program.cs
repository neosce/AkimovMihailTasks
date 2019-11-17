using AkimovMihailTasks.Tasks;
using System;


namespace Task_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_list;

            Console.WriteLine("Task_0\n" + "The task corresponds to the number in the list:");
            
            do
            {
                Console.WriteLine("1 - SEQUENCE" + "\n2 - SIMPLE" + "\n3 - SQUARE" + "\n4 - ARRAY" + "\n5 - EXIT");
                number_list = Convert.ToInt32(Console.ReadLine());

                switch (number_list)
                {
                    case 1:
                        Sequence.SequenceTask();
                        break;
                    case 2:
                        Simple.SimpleTask();
                        break;
                    case 3:
                        Square.SquareTask();
                        break;
                    case 4:
                        AkimovMihailTasks.Tasks.Array.ArrayTask(); // I don't use simply Array.
                        break;
                    default:
                        number_list = 5;
                        break;
                }

                Console.WriteLine();

            } while (number_list != 5);
        }
    }
}
