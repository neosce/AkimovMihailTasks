using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkimovMihailTasks.Tasks
{
    public class Sequence
    {

        public string FuncSequence(int seq)
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

        public static void SequenceTask()
        {

            int seq;

            Console.WriteLine("Insert the number");
            seq = Convert.ToInt32(Console.ReadLine());
            
            Sequence sequence = new Sequence();
            
            Console.WriteLine("Sequence:" + sequence.FuncSequence(seq));
        }

    }
}
