using DealShop.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealShop.ListUsers.BLL.Interfaces
{
    public interface IProductLogic
    {

        Product Add(Product product);

        Product GetById(int id);

        IEnumerable<Product> GetAll();

        string Update(Product user);

        string AddOrder(int productId, int userId);

    }
}
