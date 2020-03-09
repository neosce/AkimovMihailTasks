using DealShop.ListUser.Dao.Interfaces;
using DealShop.ListUsers.BLL.Interfaces;
using DealShop.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealShop.ListUsers.BLL
{
    public class ProductLogic : IProductLogic
    {

        private readonly IProductDao _productDao;

        public ProductLogic(IProductDao productDao)
        {
            _productDao = productDao;
        }

        Product IProductLogic.Add(Product product)
        {
            return _productDao.Add(product);
        }

        string IProductLogic.AddOrder(int productId, int userId)
        {
            return _productDao.AddOrder(productId, userId);
        }

        IEnumerable<Product> IProductLogic.GetAll()
        {
            return _productDao.GetAll();
        }

        Product IProductLogic.GetById(int id)
        {
            return _productDao.GetById(id);
        }

        string IProductLogic.Update(Product product)
        {
            return _productDao.Update(product);
        }
    }
}
