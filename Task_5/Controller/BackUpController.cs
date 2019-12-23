using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task_5.Model;

namespace Task_5.Controller
{
    public class BackUpController
    {

        BackUp backUp;

        List<string> eventsBackUp = new List<string>();
       
        int numberBackUp = 1;
        IDictionary<int, int> keyNumberBackUp = new Dictionary<int, int>();

        delegate void UserHandler();
        event UserHandler Notify;

        public void FindToLog()
        {

            using (FileStream fileStream = new FileStream("E:\\BackUp\\Log.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    while (!streamReader.EndOfStream)
                    {
                        eventsBackUp.Add(streamReader.ReadLine());
                    }
                }
            }

            UserLogSelect();

        }

        public void UserLogSelect()
        {

            uint n;
            backUp = new BackUp();

            do
            {

                DisplayTimeSession();

                var numberList = Console.ReadLine();

                Notify += ConsoleError;

                if (uint.TryParse(numberList, out n))
                {

                    if (n < numberBackUp && n != 0)
                    {
                        backUp.BackUpMain(n, keyNumberBackUp, eventsBackUp);
                    }
                    else if (n == 0)
                    {
                        break;
                    }
                    else
                    {
                        Notify?.Invoke();
                    }
                    
                }
                else
                {
                    Notify?.Invoke();
                }

                numberBackUp = 1;
                keyNumberBackUp.Clear();

            } while (n != 0);

            Notify -= ConsoleError;

        }

        private void DisplayTimeSession()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Select TIME session: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Regex regex = new Regex(@"TIME:");
            for (int i = 0; i < eventsBackUp.Count; i++)
            {
                if (regex.IsMatch(eventsBackUp[i]))
                {
                    keyNumberBackUp.Add(numberBackUp, i);
                    Console.WriteLine($"{numberBackUp++} - {eventsBackUp[i]}"); // List find time session log
                }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("0 - Cancel");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public static void ConsoleError()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("The number from the list is missing!");
            Console.WriteLine("Try once more...");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        //TODO: Delete this method it's on for test!
        public void Test()
        {
            Console.WriteLine("Number Back Up Test: " + numberBackUp);
        }

    }
}
