using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Task_2.Tasks.Inheritance.Task2._5
{
    public class MainUser
    {
        public static void mainUser()
        {

            Console.WriteLine("User:");

            try
            {

                int exit = 1, i = 1;

                Collection<User> users = new Collection<User>();

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
                    var dateTime = Console.ReadLine();
                    Console.Write("\nInput WorkExperience: ");
                    var workExperience = int.Parse(Console.ReadLine());
                    Console.Write("\nInput Position: ");
                    var position = Console.ReadLine();

                    users.Add(new User(name, surname, patronymic, dateTime, age, workExperience, position) 
                    { 
                        Name = name, 
                        Surname = surname, 
                        Patronymic = patronymic,
                        DateTime = dateTime,
                        Age = age,  
                        WorkExperience = workExperience, 
                        Position = position
                    });

                    Console.WriteLine("Add user? 0 - Exit, 1 - Add");
                    exit = int.Parse(Console.ReadLine());

                } while (exit != 0);

                foreach (var item in users)
                {
                    Console.WriteLine($"User id: {i++} \n Name: {item.Name} \n Suranme: {item.Surname} \n Patronymic: {item.Patronymic} \n Age: {item.Age} \n DateBirthday: {item.DateTime} \n WorkExperience: {item.WorkExperience} \n Position: {item.Position}");
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
