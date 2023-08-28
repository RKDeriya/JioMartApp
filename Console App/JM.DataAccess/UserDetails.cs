using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace JM.DataAccess
{
    public class UserDetailsCRUD
    {
        public void InsertUserDetails()
        {
            //create connection string and assigning to class
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());

            //generate query
            string SpQuery = "JioMart.InsertUserDetails";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@userDetailsId", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@userFirstName", SqlDbType.VarChar).Value = "DarshanBhai";
            cmd.Parameters.Add("@userLastName", SqlDbType.VarChar).Value = "Modi";
            cmd.Parameters.Add("@userAddress", SqlDbType.VarChar).Value = "Surat,Gujarat";
            cmd.Parameters.Add("@userMobileNo", SqlDbType.VarChar).Value = "4591286570";
            cmd.Parameters.Add("@userWalletbalance", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "I";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("data inserted successfully");
        }

        public void UpdateUserDetails()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());
            //generate query
            string SpQuery = "JioMart.InsertUserDetails";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@userDetailsId", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@userFirstName", SqlDbType.VarChar).Value = "Darshan";
            cmd.Parameters.Add("@userLastName", SqlDbType.VarChar).Value = "Modi";
            cmd.Parameters.Add("@userAddress", SqlDbType.VarChar).Value = "Mehsana,Gujarat";
            cmd.Parameters.Add("@userMobileNo", SqlDbType.VarChar).Value = "4591286570";
            cmd.Parameters.Add("@userWalletbalance", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "U";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("data updated successfully");
        }

        public void DeleteUserDetails()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());
            //generate query
            string SpQuery = "JioMart.InsertUserDetails";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@userDetailsId", SqlDbType.Int).Value = 1;
            cmd.Parameters.Add("@userFirstName", SqlDbType.VarChar).Value = "Darshan";
            cmd.Parameters.Add("@userLastName", SqlDbType.VarChar).Value = "Modi";
            cmd.Parameters.Add("@userAddress", SqlDbType.VarChar).Value = "Mehsana,Gujarat";
            cmd.Parameters.Add("@userMobileNo", SqlDbType.VarChar).Value = "4591286570";
            cmd.Parameters.Add("@userWalletbalance", SqlDbType.Int).Value = 0;
            cmd.Parameters.Add("@opType", SqlDbType.VarChar).Value = "D";

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("data Deleted successfully");

        }
        public void GetUserDetails()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());
            //generate query
            string SpQuery = "Select * from JioMart.UserDetails where UserDetailsId = 2";

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
