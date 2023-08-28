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
    public class CartDetailsCRUD
    {
        public void InsertCartDetails()
        {

            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());
            //generate query
            string SpQuery = "JioMart.InsertCartDetails";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@cartDetailsId", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@productDetaisId", SqlDbType.Int).Value = 11;
            cmd.Parameters.Add("@productQuantity", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@cartTotalPrice", SqlDbType.Float).Value = 333F;
            cmd.Parameters.Add("@userDetailsId", SqlDbType.VarChar).Value =1;
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "I";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Add to cart successfully");
        }
        public void UpdateCartDetails()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());
            //generate query
            string SpQuery = "JioMart.InsertCartDetails";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);

            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@cartDetailsId", SqlDbType.Int).Value = 101;
            cmd.Parameters.Add("@productDetaisId", SqlDbType.Int).Value = 11;
            cmd.Parameters.Add("@productQuantity", SqlDbType.Int).Value = 2;
            cmd.Parameters.Add("@cartTotalPrice", SqlDbType.Float).Value = 666F;
            cmd.Parameters.Add("@userDetailsId", SqlDbType.VarChar).Value = 1;
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "U";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Update cart successfully");
        }
        public void DeleteCartDetails()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());
            //generate query
            string SpQuery = "Delete From JioMart.CartDetails where CartDetailsId = @cartDetailsId";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);

            
            cmd.Parameters.Add("@cartDetailsId", SqlDbType.Int).Value = 101;

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Delete cart successfully");
        }

        public void GetCartDetails()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());
            //generate query
            string SpQuery = "Select * from JioMart.CartDetails where CartDetailsId = 101";

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = new SqlCommand(SpQuery, sqlconnection);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("{0} {1} {3} {4} {5} {6} {7}", row[0] + "\t", row[1] + "\t", row[2] + "\t", row[3] + "\t", row[4] + "\t", row[5] + "\t", row[6] + "\t", row[7] + "\t");
            }
        }
    }
}
