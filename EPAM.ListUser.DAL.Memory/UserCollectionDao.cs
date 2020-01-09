using EPAM.ListUser.Dao.Interfaces;
using EPAM.ListUsers.Entities;
using System.Collections.Generic;
using System.Linq;

namespace EPAM.ListUser.DAL.Memory
{
    public class UserCollectionDao : IUserDao
    {

        private static readonly Dictionary<int, User> _user = new Dictionary<int, User>();

        User IUserDao.Add(User user)
        {
            var lastId = _user.Keys.Count > 0
                ? _user.Keys.Max()
                : 0;

            user.Id = lastId + 1;

            _user.Add(user.Id, user);

            return user;
        }

        string IUserDao.DeletedById(int id)
        {
            if (_user.ContainsKey(id))
            {
                _user.Remove(id);
                
                return $"This is id:{id} was deleted!";
            }
            else
            {
                return $"This is id:{id} missing or not added!";
            }

        }

        IEnumerable<User> IUserDao.GetAll()
        {
            return _user.Values;
        }

        User IUserDao.GetById(int id)
        {
            _user.TryGetValue(id, out var user);

            return user;
        }
    }
}
