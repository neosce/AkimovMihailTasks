using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Task_5.Controller
{
    public class ReaderController
    {

        [STAThread]
        public IEnumerable<string> RecordLogBackUp(string pathFile)
        {
            //IEnumerable<string> pathTxt;
            Regex regex = new Regex(@"[^ ]+\.txt");

            if (regex.IsMatch(pathFile))
            {
                using (StreamReader reader = File.OpenText(pathFile))
                {

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        yield return line;
                    }

                }
            }
            else
            {
                yield return default;
            }
            

            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Error: {ex.ToString()}");
            //}

            //return default;

        }

    }
}
