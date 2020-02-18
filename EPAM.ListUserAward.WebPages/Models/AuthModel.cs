using EPAM.ListUserAward.WebPages.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPAM.ListUserAward.WebPages.Models
{
    public class AuthModel
    {

        private static readonly Dictionary<int, UserAuth> _userAuth = new Dictionary<int, UserAuth>();

        public UserAuth Add(UserAuth userAuth)
        {

            int count = 0;

            foreach (var pair in _userAuth)
            {
                if (pair.Value.Email == userAuth.Email)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                var lastId = _userAuth.Keys.Count > 0
                    ? _userAuth.Keys.Max()
                    : 0;

                userAuth.Id = lastId + 1;

                _userAuth.Add(userAuth.Id, userAuth);

                return userAuth;
            }

            return userAuth;
        }

        public UserAuth GetById(int id)
        {
            _userAuth.TryGetValue(id, out var userAuth);

            return userAuth;
        }

        public UserAuth GetByEmail(string email)
        {
            foreach (var user in _userAuth.Values)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }

        public string DeletedById(int id)
        {
            if (_userAuth.ContainsKey(id))
            {
                _userAuth.Remove(id);

                return $"This is id:{id} was deleted!";
            }
            else
            {
                return $"This is id:{id} missing or not added!";
            }
        }

        public IEnumerable<UserAuth> GetAll()
        {
            return _userAuth.Values;
        }

    }
}