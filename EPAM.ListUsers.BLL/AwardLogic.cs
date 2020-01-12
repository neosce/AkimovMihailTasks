using EPAM.ListUser.Dao.Interfaces;
using EPAM.ListUsers.BLL.Interfaces;
using EPAM.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.ListUsers.BLL
{
    public class AwardLogic : IAwardLogic
    {

        private readonly IAwardDao _awardDao;

        public AwardLogic(IAwardDao awardDao)
        {
            _awardDao = awardDao;
        }

        public Award Add(Award award)
        {
            return _awardDao.Add(award);
        }

        public IEnumerable<Award> GetAll()
        {
            return _awardDao.GetAll();
        }

        public Award GetById(int id)
        {
            return _awardDao.GetById(id);
        }
    }
    
}
