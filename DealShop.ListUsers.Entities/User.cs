using System;
using System.Collections.Generic;

namespace DealShop.ListUsers.Entities
{
    public class User
    {

        public int Id { get; set; }

        public string LoginEmail { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

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

        public string Address { get; set; }

        public decimal Money { get; set; }

        public int CreditsCardNumber { get; set; }

        public byte[] userLogo { get; set; }

        public List<int> userProduct { get; set; }

        public string UserRights { get; set; }

    }
}
