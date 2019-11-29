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

                int exit = 1, i = 1;

                ObservableCollection<User> users = new ObservableCollection<User>();

                do
                {

                    Console.Write("Input Name: ");
                    var name = Console.ReadLine();
                    Console.Write("\nInput Surname: ");
                    var surname = Console.ReadLine();
                    Console.Write("\nInput Patronymic: ");
                    var patronymic = Console.ReadLine();
                    Console.Write("\nInput Age: ");
                    var age = int.Parse(Console.ReadLine());
                    Console.Write("\nInput DateBirthday: ");
                    var dateTime = int.Parse(Console.ReadLine());

                    users.Add(new User(name, surname, patronymic, age, dateTime) { Name = name, Surname = surname, Patronymic = patronymic, Age = age, DateTime = dateTime });
                    
                    Console.WriteLine("Add user? 0 - Exit, 1 - Add");
                    exit = int.Parse(Console.ReadLine());

                } while (exit != 0);

                foreach (var item in users)
                {
                    Console.WriteLine($"User id: {i++} \n Name: {item.Name} \n Suranme: {item.Surname} \n Patronymic: {item.Patronymic} \n Age: {item.Age} \n DateBirthday: {item.DateTime}");
                }

                Console.WriteLine();
                
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect input");
            }

        }

    }
}
