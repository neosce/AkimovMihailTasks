using System;
using System.Collections.ObjectModel;

namespace Task_2.Tasks.Encapsulation.Task2._3
{
    public class MainUser
    {

        public static void mainUser()
        {

            Console.WriteLine("User:");

            try
            {

                int exit = 1;
                int i = 1;

                Collection<User> users = new Collection<User>();

                do
                {

                    Console.Write("Enter Name: ");
                    var name = Console.ReadLine();
                    Console.Write("\nEnter Surname: ");
                    var surname = Console.ReadLine();
                    Console.Write("\nEnter Patronymic: ");
                    var patronymic = Console.ReadLine();
                    Console.Write("\nEnter Age: ");
                    var age = int.Parse(Console.ReadLine());
                    Console.Write("\nEnter date of Birth in format yyyy-mm-dd: ");
                    var dateTime = Console.ReadLine();

                    users.Add(new User(name, surname, patronymic, dateTime, age) 
                    { 
                        Name = name, 
                        Surname = surname,
                        Patronymic = patronymic,
                        DateTime = dateTime,
                        Age = age                        
                    });
                    
                    Console.WriteLine("Add user? 0 - Exit, 1 - Add");
                    exit = int.Parse(Console.ReadLine());

                } while (exit != 0);

                foreach (var item in users)
                {
                    Console.WriteLine($"User id: {i++} \n Name: {item.Name} \n Suranme: {item.Surname} \n Patronymic: {item.Patronymic} \n Age: {item.Age} \n Date Birthday: {item.DateTime}");
                }

                Console.WriteLine();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

        }

    }
}
