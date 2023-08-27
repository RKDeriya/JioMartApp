using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JM.DataAccess
{
    public class CategoryCRUD
    {
        public void InsertCategory()
        {
            //create connection string
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());

            //generate query
            string SpQuery = "JioMart.InsertCategory";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = "Electronics";
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "I";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Category inserted successfully");
        }

        public void UpdateCategory()
        {
            //create connection string
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());

            //generate query
            string SpQuery = "JioMart.InsertCategory";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = "Electronics & Electrical";
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "U";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Category updated successfully");
        }

        public void DeleteCategory()
        {
            //create connection string
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());

            //generate query
            string SpQuery = "JioMart.InsertCategory";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@categoryId", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@categoryName", SqlDbType.VarChar).Value = "Electronics";
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "D";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Category Deleted successfully");
        }

        public void GetCategory()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());
            //generate query
            string SpQuery = "Select * from JioMart.Category where CategoryId = 10001";

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = new SqlCommand(SpQuery, sqlconnection);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("{0} {1} {3}", row[0] + "\t", row[1] + "\t", row[2] + "\t", row[3]);
            }
        }
    }
}
