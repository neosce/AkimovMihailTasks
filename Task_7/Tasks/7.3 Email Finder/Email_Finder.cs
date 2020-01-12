using System;
using System.Text.RegularExpressions;

namespace Task_7.Tasks._7._3_Email_Finder
{
    internal class Email_Finder
    {

        public static void StartEmail()
        {

            Regex regex = new Regex(@"[a-z0-9+_.-]+@[a-z0-9.-]+");
            string textExapmle = "Ivan: ivan@mail.ru, Petr: p_ivanov@mail.rol.ru";

            var result = regex.Matches(textExapmle);

            Console.WriteLine("Find email adress:");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }

    }
}
