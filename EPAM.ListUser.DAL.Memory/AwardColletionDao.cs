using EPAM.ListUser.Dao.Interfaces;
using EPAM.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.ListUser.DAL.Memory
{
    public class AwardColletionDao : IAwardDao
    {

        private static readonly Dictionary<int, Award> _award = new Dictionary<int, Award>();

        Award IAwardDao.Add(Award award)
        {

            int count = 0;

            foreach (var pair in _award)
            {

                if (pair.Value.Title == award.Title)
                {
                    count++;
                }
            }
            if (count == 0)
            {
                var lastId = _award.Keys.Count > 0
                            ? _award.Keys.Max()
                            : 0;

                award.Id = lastId + 1;

                _award.Add(award.Id, award);

                return award;
            }
            return award;
        }

        IEnumerable<Award> IAwardDao.GetAll()
        {
            return _award.Values;
        }

        Award IAwardDao.GetById(int id)
        {
            _award.TryGetValue(id, out var award);

            return award;
        }

        string IAwardDao.DeletedById(int id)
        {
            if (_award.ContainsKey(id))
            {
                _award.Remove(id);

                return $"This is id:{id} was deleted!";
            }
            else
            {
                return $"This is id:{id} missing or not added!";
            }
        }
    }
}
