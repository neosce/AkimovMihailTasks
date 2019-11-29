namespace Task_2.Tasks.Inheritance.Task2._5
{
    public class User: Employee
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int DateTime { get; set; }
        public int Age { get; set; }

        public User(string Name, string Surname, string Patronymic, int DateTime, int Age, int WorkExperience, string Position)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Patronymic = Patronymic;
            this.DateTime = DateTime;
            this.Age = Age;
            this.WorkExperience = WorkExperience;
            this.Position = Position;
        }

    }
}
