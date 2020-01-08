using System;
using System.Numerics;

namespace AkimovMihailTasks.Tasks
{
    public class Simple
    {

        public static void SimpleTask()
        {

            BigInteger N;
            Simple simple = new Simple();

            Console.WriteLine("Insert the number N:");
            N = Convert.ToUInt64(Console.ReadLine());

            Console.WriteLine("Simple\n The Farm Test:\n");
            if (N == 1)
            {
                Console.WriteLine("At present, in mathematics, it is customary not to attribute\n" +
                    "1 to either simple or composite numbers, since this violates the uniqueness\n" +
                    "of factorization, which is important for number theory.");
            }
            else
            {
                Console.WriteLine(simple.Farm(N));
            }

        }

        private bool Farm(BigInteger n)
        {
            // 561 - smallest Carmichael number
            if (n < 1 || n == 561 || n == 1105 || n == 1729 || n == 2465 || n == 2821)
            {
                return false;
            }

            if(n == 2)
            {
                return true;
            }

            for (int i = 1; i < n; i++)
            {

                BigInteger ferm = 1;

                for(int j = 0; j != n ; j++)
                {
                    ferm *= i;
                }

                ferm -= i;

                if ((ferm % n) != 0)
                {
                    return false;
                }

            }
            return true;
        }

    }
}
