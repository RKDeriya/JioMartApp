using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using JM.Model;

namespace JM.DataAccess
{
    public class OrderDetailsCRUD
    {
        /*public void InsertOrderDetails()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());

            //generate query
            string SpQuery = "JioMart.InsertOrderDetails";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@cartDetailsId", SqlDbType.Int).Value = 12;
            cmd.Parameters.Add("@orderPaymentMode", SqlDbType.VarChar).Value = "UPI";
            cmd.Parameters.Add("@orderTotalPrice", SqlDbType.Float).Value = 0;
   
            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Order details inserted successfully");
        }
        */
        public void InsertOrderDetails(OrderDetails details)
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());

            //generate query
            string SpQuery = "JioMart.InsertOrderDetails";

            //create command
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@cartDetailsId", details.CartDetailsId);
            cmd.Parameters.AddWithValue("@orderPaymentMode", details.OrderPaymentMode);
            cmd.Parameters.AddWithValue("@orderTotalPrice", details.OrderTotalPrice);
            cmd.Parameters.AddWithValue("@orderdeliveryStatus", details.OrderDeliveryStatus);

            //cmd.Parameters.Add("@cartDetailsId", SqlDbType.Int).Value = 12;
            //cmd.Parameters.Add("@orderPaymentMode", SqlDbType.VarChar).Value = "UPI";
            //cmd.Parameters.Add("@orderTotalPrice", SqlDbType.Float).Value = 0;

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Order details inserted successfully");
        }
        public void GetOrderDetails()
        {
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());
            //generate query
            string SpQuery = "Select * from JioMart.OrderDetails where OrderDetailsId = 1";

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = new SqlCommand(SpQuery, sqlconnection);

            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("{0} {1} {3} {4} {5} {6} {7}", row[0] + "\t", row[1] + "\t", row[2] + "\t", row[3] + "\t", row[4] + "\t", row[5] + "\t", row[6] + "\t", row[7] + "\t");
            }

        }
        public void UpdateOrderDetails()
        {
            Console.WriteLine("Enter Order Id to update delivery status");
            int id =Convert.ToInt32( Console.ReadLine());
            
            SqlConnection sqlconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectwithJioMartDatabase"].ToString());
            //generate query
            string SpQuery = "Update JioMart.OrderDetails set OrderDeliverystatus='Delivered' where OrderDetailsId = @id";
            SqlCommand cmd = new SqlCommand(SpQuery, sqlconnection);
            //cmd.Parameters.Add("@OrderDetailsId", SqlDbType.Int).Value = 1;
            cmd.Parameters.AddWithValue("@id",id);

            sqlconnection.Open();
            cmd.ExecuteNonQuery();
            sqlconnection.Close();
            Console.WriteLine("Order details Updated successfully");

        }
    }
}
