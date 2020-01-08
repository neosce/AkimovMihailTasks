using System;

namespace AkimovMihailTasks.Tasks
{
    public class Square
    {

        public static void SquareTask()
        {
            int N;
            Square square = new Square();

            Console.WriteLine("Insert the number N:");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Square:\n");
            square.StarSquare(N);
        }

        private void StarSquare(int N)
        {
            int empty, counter=0;

            if (N*N % 2 != 0)
            {

                empty = (N * N / 2) + 1;
                
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        counter++;
                        if (counter == empty)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Number is not odd!");
            }
        }

    }
}
