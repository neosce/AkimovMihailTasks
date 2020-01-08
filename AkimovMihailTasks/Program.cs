using AkimovMihailTasks.Tasks;
using System;

namespace Task_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.WriteLine("Task_0\n" + "The task corresponds to the number in the list:");
            
            do
            {

                Console.WriteLine("1 - SEQUENCE" + "\n2 - SIMPLE" + "\n3 - SQUARE" + "\n4 - ARRAY" + "\n0 - EXIT");
                
                var number_list = Console.ReadLine();
                
                if (int.TryParse(number_list, out n) && n < 5 && n >= 0)
                {
                    switch (n)
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
                            n = 0;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Try once more... ");
                    n = -1;
                }

            } while (n != 0);
        }
    }
}
