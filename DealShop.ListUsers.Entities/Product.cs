using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealShop.ListUsers.Entities
{
    public class Product
    {

        public int Id { get; set; }

        public string NameProduct { get; set; }

        public decimal Price { get; set; }

        public string Color { get; set; }

        public string Gender { get; set; }

        public string Description { get; set; }

        public int QuantityOfGoods { get; set; }

        public string Category { get; set; }

        public int Size { get; set; }

        public byte[] ImageProduct { get; set; }

    }
}
