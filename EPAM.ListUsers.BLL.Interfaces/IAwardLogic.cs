using EPAM.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.ListUsers.BLL.Interfaces
{
    public interface IAwardLogic
    {

        Award Add(Award award);

        Award GetById(int id);

        IEnumerable<Award> GetAll();

        string DeletedById(int id);

    }
}
