using Microsoft.Data.SqlClient;
using RapidOrder.Common.DTO;
using RapidOrder.Common;
using RapidOrder.Common.RabbitMQ;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace RapidOrder.Common.Database.Mssql
{
    public class MssqlDB : IDbHelper
    {
        private readonly string _connectionString;
        public MssqlDB(DbConfig config)
        {
            _connectionString = config.ConnectionString;
        }

        #region Cart

        // ADD to cart
        public bool AddOrderToCart()
        {
            int rowsAffected;
            try
            {
                string query = "INSERT INTO Cart (UserId , ProductId, Quantity) VALUES (1, 3, 11)";
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    rowsAffected = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return rowsAffected > 0;
        }
        #endregion

        public List<Product> GetProductList()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    using (SqlCommand command = new SqlCommand("GetAllProducts", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return dt.toList<Product>();
        }
    }
}
