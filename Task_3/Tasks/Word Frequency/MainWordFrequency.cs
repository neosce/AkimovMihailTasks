using System;

namespace Task_3.Tasks.Word_Frequency
{
    public class MainWordFrequency
    { 

        public static void MainWFrequency()
        {
            string text = "It, is just very beautiful, such beautiful text. So I liked him, that everyone liked, and LIked beautiful and me.";
            
            Console.WriteLine("Word Frequency".ToUpper());
            Console.WriteLine(text);

            try
            {
                Algorithm_Word_Frequency.AlgorithmWordF(text);
            }
            catch (Exception)
            {
                Console.WriteLine("Algorithm crash...");
            }
        }

    }
}
