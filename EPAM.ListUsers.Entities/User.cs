using System;

namespace EPAM.ListUsers.Entities
{
    public class User
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirthday { get; set; }

        public int Age 
        {
            get
            {
                var today = DateTime.Today;
                var a = (today.Year * 100 + today.Month) * 100 + today.Day;
                var b = (DateOfBirthday.Year * 100 + DateOfBirthday.Month) * 100 + DateOfBirthday.Day;

                return (a - b) / 10000;
            }
        }

        public override string ToString()
        {
            return $"Id = {Id}\n Name: {Name}\n Age: {Age}\n Date Of Birthday - {DateOfBirthday.ToString("dd.MM.yyyy")}\n";
        }

    }
}
