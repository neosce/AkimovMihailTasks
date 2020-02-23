using EPAM.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.ListUser.Dao.Interfaces
{
    public interface IAwardDao
    {

        Award Add(Award award);

        Award GetById(int id);

        IEnumerable<Award> GetAll();

        string DeletedById(int id);
    }
}
