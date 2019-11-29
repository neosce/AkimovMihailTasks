namespace Task_2.Tasks.Encapsulation.Task2._3
{
    public class User
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int DateTime { get; set; }
        public int Age { get; set; }

        public User(string Name, string Surname, string Patronymic, int DateTime, int Age)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.DateTime = DateTime;
            this.Age = Age;
        }

    }
}
