using DealShop.ListUser.Dao.Interfaces;
using DealShop.ListUsers.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealShop.ListUsers.DAL
{
    public class ProductDao : IProductDao
    {

        private string _connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DealShop;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private List<Product> _products = new List<Product>();

        Product IProductDao.Add(Product product)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddProduct";

                var nameProductParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@NameProduct",
                    Value = product.NameProduct,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(nameProductParametr);

                var priceParametr = new SqlParameter()
                {
                    DbType = DbType.Decimal,
                    ParameterName = "@Price",
                    Value = product.Price,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(priceParametr);

                var colorParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Color",
                    Value = product.Color,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(colorParametr);

                var genderParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Gender",
                    Value = product.Gender,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(genderParametr);

                var descriptionParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Description",
                    Value = product.Description,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(descriptionParametr);

                var quantityOfGoodsParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@QuantityOfGoods",
                    Value = product.QuantityOfGoods,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(quantityOfGoodsParametr);

                var categoryParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Category",
                    Value = product.Category,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(categoryParametr);

                var sizeParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Size",
                    Value = product.Size,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(sizeParametr);

                var imageProductParametr = new SqlParameter()
                {
                    DbType = DbType.Binary,
                    ParameterName = "@ImageProduct",
                    Value = product.ImageProduct,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(imageProductParametr);

                var idParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = product.Id,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(idParametr);

                connection.Open();

                command.ExecuteNonQuery();
            }
            return product;
        }

        string IProductDao.AddOrder(int productId, int userId)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "AddOrder";

                var idProductParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IdProduct",
                    Value = productId,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idProductParametr);

                var idUserParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@IdUser",
                    Value = userId,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idUserParametr);

                var statusParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Status",
                    Value = "Awaiting",
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(statusParametr);

                var orderParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Order",
                    Value = 1,
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(orderParametr);

                connection.Open();

                command.ExecuteNonQuery();
            }

            return "Ok add!";
        }

        IEnumerable<Product> IProductDao.GetAll()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "GetAllProduct";

                connection.Open();

                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    if (!_products.Exists(x => x.Id == (int)reader["Id"]))
                    {
                        if (reader["ImageProduct"] == DBNull.Value)
                        {
                            _products.Add(new Product
                            {
                                Id = (int)reader["Id"],
                                NameProduct = reader["NameProduct"].ToString(),
                                Price = (decimal)reader["Price"],
                                Color = reader["Color"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Description = reader["Description"].ToString(),
                                QuantityOfGoods = (int)reader["QuantityOfGoods"],
                                Category = reader["Category"].ToString(),
                                Size = (int)reader["Size"]
                            });
                        }
                        else
                        {
                            _products.Add(new Product
                            {
                                Id = (int)reader["Id"],
                                NameProduct = reader["NameProduct"].ToString(),
                                Price = (decimal)reader["Price"],
                                Color = reader["Color"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                Description = reader["Description"].ToString(),
                                QuantityOfGoods = (int)reader["QuantityOfGoods"],
                                Category = reader["Category"].ToString(),
                                Size = (int)reader["Size"],
                                ImageProduct = (byte[])reader["ImageProduct"]
                            });
                        }
                        
                    }
                }
            }

            return _products;
        }

        Product IProductDao.GetById(int id)
        {
            Product product = new Product();
            product = _products.Find(x => x.Id == id);

            if (product.Id == id)
            {
                return product;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    var command = connection.CreateCommand();

                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "GetByIdProduct";

                    connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        product.Id = (int)reader["Id"];
                        product.NameProduct = reader["NameProduct"].ToString();
                        product.Price = (decimal)reader["Price"];
                        product.Color = reader["Color"].ToString();
                        product.Gender = reader["Gender"].ToString();
                        product.Description = reader["Description"].ToString();
                        product.QuantityOfGoods = (int)reader["QuantityOfGoods"];
                        product.Category = reader["Category"].ToString();
                        product.Size = (int)reader["Size"];
                        product.ImageProduct = (byte[])reader["ImageProduct"];
                    }
                }
                return product;
            }
        }

        string IProductDao.Update(Product product)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateProduct";

                var nameProductParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@NameProduct",
                    Value = product.NameProduct,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(nameProductParametr);

                var priceParametr = new SqlParameter()
                {
                    DbType = DbType.Decimal,
                    ParameterName = "@Price",
                    Value = product.Price,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(priceParametr);

                var colorParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Color",
                    Value = product.Color,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(colorParametr);

                var genderParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Gender",
                    Value = product.Gender,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(genderParametr);

                var descriptionParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Description",
                    Value = product.Description,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(descriptionParametr);

                var quantityOfGoodsParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@QuantityOfGoods",
                    Value = product.QuantityOfGoods,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(quantityOfGoodsParametr);

                var categoryParametr = new SqlParameter()
                {
                    DbType = DbType.String,
                    ParameterName = "@Category",
                    Value = product.Category,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(categoryParametr);

                var sizeParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Size",
                    Value = product.Size,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(sizeParametr);

                var imageProductParametr = new SqlParameter()
                {
                    DbType = DbType.Binary,
                    ParameterName = "@ImageProduct",
                    Value = product.ImageProduct,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(imageProductParametr);

                var idParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = product.Id,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(idParametr);

                connection.Open();

                command.ExecuteNonQuery();
            }

            return "Update product OK";
        }

        string IProductDao.UpdateQuantityOfGoods(int productId, int QuantityOfGoods)
        {

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                var command = connection.CreateCommand();

                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "UpdateQuantityOfGoods";

                var quantityOfGoodsParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@QuantityOfGoods",
                    Value = QuantityOfGoods,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(quantityOfGoodsParametr);

                var productIdParametr = new SqlParameter()
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id",
                    Value = productId,
                    Direction = ParameterDirection.Input
                };
                command.Parameters.Add(productIdParametr);

                connection.Open();

                command.ExecuteNonQuery();
            }

            return "Ok QuantityOfGoods update";
        }
    }
}
