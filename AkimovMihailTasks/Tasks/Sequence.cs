using System;

namespace AkimovMihailTasks.Tasks
{
    public class Sequence
    {

        public static void SequenceTask()
        {

            int seq;
            Sequence sequence = new Sequence();

            Console.WriteLine("Insert the number N:");
            seq = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sequence:\n" + sequence.FuncSequence(seq));
        }

        private string FuncSequence(int seq)
        {
            int start = 1;
            string return_seq = "1";

            while (start != seq)
            {
                start++;
                return_seq += ",";
                return_seq += start.ToString();
            }

            return return_seq;
        }

    }
}
