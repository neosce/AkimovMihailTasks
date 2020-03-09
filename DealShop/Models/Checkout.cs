using DealShop.ListUsers.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealShop.Models
{
    public class Checkout
    {

        public void AddCheckout(string productCartName, string valueCount, int userId)
        {
            var productLogic = DependencyResolver.ProductLogic;
            //int[] myInts = Array.ConvertAll(valueCount, int.Parse);

            foreach (var name in productCartName.Split(','))
            {
                foreach (var product in productLogic.GetAll())
                {
                    if (name == product.NameProduct)
                    {
                        //var value = product.QuantityOfGoods;
                        productLogic.AddOrder(product.Id, userId);
                    }
                }
            }

        }


    }
}