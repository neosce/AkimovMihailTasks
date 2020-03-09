using DealShop.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealShop.ListUsers.BLL.Interfaces
{
    public interface IUserLogic
    {

        User Add(User user);

        User GetById(int id);

        string DeletedById(int id);

        IEnumerable<User> GetAll();

        string Update(User user);

    }
}
