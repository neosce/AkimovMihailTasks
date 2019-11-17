using AkimovMihailTasks.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_list;
            string description = "1 - SEQUENCE" + "\n2 - SIMPLE" + "\n3 - SQUARE" + "\n4 - ARRAY" + "\n5 - EXIT";

            Console.WriteLine("Task_0");
            Console.WriteLine("The task corresponds to the number in the list:");
            
            do
            {
                Console.WriteLine(description);
                number_list = Convert.ToInt32(Console.ReadLine());

                switch (number_list)
                {
                    case 1:
                        Sequence.SequenceTask();
                        Console.WriteLine();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    default:
                        number_list = 5;
                        break;
                }

            } while (number_list != 5) ;
           

        }
    }
}
