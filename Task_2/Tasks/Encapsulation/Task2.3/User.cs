using System;
using System.Text.RegularExpressions;

namespace Task_2.Tasks.Encapsulation.Task2._3
{
    public class User
    {

        string dateTime;
        private int age;
        Regex dateRegex = new Regex("(19|20)\\d\\d[- /.](0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])");

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string DateTime 
        {
            get
            {
                return dateTime;
            }
            set
            {
                if (dateRegex.IsMatch(value))
                {
                    dateTime = value;
                }
                else
                {
                    throw new FormatException("DateTime is incorrect!");
                }
            }
        }
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 120)
                {
                    age = value;
                }
                else
                {
                    throw new FormatException("Age is incorrect!");
                }
            }
        }

        public User(string Name, string Surname, string Patronymic, string DateTime, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.DateTime = DateTime;
            this.Age = Age;
        }

    }
}
