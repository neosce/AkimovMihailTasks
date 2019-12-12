using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4.Tasks._4._5._To_Int_Or_Not_To_Int
{
    public class To_Int_Or_Not_To_Int
    {
        public static void ToIntOrNotToIntMain()
        {
            Console.WriteLine("To Int Or Not To Int Main".ToUpper());

            try
            {
                var value = Console.ReadLine();
                Console.WriteLine(value.ToInt());
            }
            catch (Exception)
            {
                Console.WriteLine("Algorithm is crash!!!!!");
            }
        }
    }
}
