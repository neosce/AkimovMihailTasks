using DealShop.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealShop.ListUser.Dao.Interfaces
{
    public interface IProductDao
    {

        Product Add(Product product);

        Product GetById(int id);

        IEnumerable<Product> GetAll();

        string Update(Product product);

        string AddOrder(int productId, int userId);

        string UpdateQuantityOfGoods(int productId, int QuantityOfGoods);

    }
}
