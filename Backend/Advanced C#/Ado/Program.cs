using Microsoft.Data.SqlClient;
using System.Linq.Expressions;
using System.Text;

namespace Ado
{
    public class Program
    {
        static void Main(string[] args)
        {
            // string connectionString = "Server=HOSSAM;Database=Hossam;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
            var con = DbConnectionSingleton.Instance.GetConnection();

            //--1
           
            string query = @"SELECT Count(*) FROM Products";
            SqlCommand cmd = new SqlCommand(query, con);
            var result = (int)cmd.ExecuteScalar();
            Console.WriteLine(result);
            
            con.Close();
            //--2
            var con1 = DbConnectionSingleton.Instance.GetConnection();
            List<Products> products = new List<Products>();
            string query2 = @"select id,name,price from products";
            SqlCommand cmd2 = new SqlCommand(query2, con1);
            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                Products product = new Products();
                product.Id = reader.GetInt32(0);
                product.Name = reader.GetString(1);
                product.Price = reader.GetDecimal(2);
                products.Add(product);
            }
            con1.Close();
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }


            //--3
            var con2 = DbConnectionSingleton.Instance.GetConnection();
            string query3 = @"SELECT 
                                    o.OrderId,
                                    o.CustomerName,
                                    p.Name AS ProductName,
                                    p.Price
                                    FROM Orders o
                                    JOIN OrderProducts op ON o.OrderId = op.OrderId
                                    JOIN Products p ON op.ProductId = p.Id;";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            SqlDataReader rdr = cmd3.ExecuteReader();
            while (rdr.Read())
            {
                Console.WriteLine($"orderId: {rdr.GetInt32(0)} ,CustomerName: {rdr.GetString(1)} ,ProductName: {rdr.GetString(2)} ,Price: {rdr.GetDecimal(3)}");
            }
            con2.Close();




        }
    }
}
