using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.DataAccess
{
    public class ProductDetailsCRUD
    {

        public void InsertProductDetails()
        {
            //create connection string
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());

            //generate query
            string SpQuery = "JioMart.InsertProductDetails";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@productDetailsId", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@productName", SqlDbType.VarChar).Value = "Surf Excel Matic liqid";
            cmd.Parameters.Add("@productPrice", SqlDbType.Float).Value = 329F;
            cmd.Parameters.Add("@productStockQuantity", SqlDbType.Int).Value = 100;
            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = 10001;
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "I";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Product Details inserted successfully");
        }
        public void UpdateProductDetails()
        {
            //create connection string
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());

            //generate query
            string SpQuery = "JioMart.InsertProductDetails";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@productDetailsId", SqlDbType.Int).Value = 11;
            cmd.Parameters.Add("@productName", SqlDbType.VarChar).Value = "Surf Excel Matic liqid";
            cmd.Parameters.Add("@productPrice", SqlDbType.Float).Value = 328F;
            cmd.Parameters.Add("@productStockQuantity", SqlDbType.Int).Value = 100;
            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = 10001;
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "U";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Product Details Updated successfully");
        }

        public void DeleteProductDetails()
        {
            //create connection string
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());

            //generate query
            string SpQuery = "JioMart.InsertProductDetails";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@productDetailsId", SqlDbType.Int).Value = 11;
            cmd.Parameters.Add("@productName", SqlDbType.VarChar).Value = "Surf Excel Matic liqid";
            cmd.Parameters.Add("@productPrice", SqlDbType.Float).Value = 333F;
            cmd.Parameters.Add("@productStockQuantity", SqlDbType.Int).Value = 100;
            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = 10001;
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "I";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Product Details inserted successfully");
        }

        public void GetProductDetails()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());
            //generate query
            string SpQuery = "Select * from JioMart.ProductDetails";

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = new SqlCommand(SpQuery, sqlconnection);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6}", row[0] + "\t", row[1] + "\t", row[2] + "\t", row[3] + "\t", row[4] + "\t", row[5] + "\t", row[6] + "\t");
            }
        }
    }
}
