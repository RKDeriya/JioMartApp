using JM.DataAccess;
using JM.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JioMartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDetailsCRUD objUserDetailsCRUD = new UserDetailsCRUD();

            //Just show the Generic and property
            //UserDetails objuserDetails = new UserDetails();
            //objuserDetails.UserFirstName = "Rajesh";
            //Console.WriteLine(objuserDetails.UserFirstName);

            //
         


           //Insert user Details
           

           //update user details
           //objUserDetailsCRUD.UpdateUserDetails();

           //Get user Details
           //objUserDetailsCRUD.GetUserDetails();

           //Delete user details
           //objUserDetailsCRUD.DeleteUserDetails();


           //Now for category
           CategoryCRUD objCategoryCRUD = new CategoryCRUD();

            // Insert Category
            //objCategoryCRUD.InsertCategory();

            // Update Category Details
            //objCategoryCRUD.UpdateCategory();

            // get category details
            //objCategoryCRUD.GetCategory();

            // Delete Category
            //objCategoryCRUD.DeleteCategory();

            //now for Product Details
            ProductDetailsCRUD objProductDetailsCRUD = new ProductDetailsCRUD();

            //insert Product details
            //objProductDetailsCRUD.InsertProductDetails();
            //objProductDetailsCRUD.UpdateProductDetails();
            //objProductDetailsCRUD.DeleteProductDetails();
            //objProductDetailsCRUD.GetProductDetails();


            //now for Cartdetails
            CartDetailsCRUD ObjCartDetailsCRUD = new CartDetailsCRUD();

            //calling all cart method
            //ObjCartDetailsCRUD.InsertCartDetails();
            //ObjCartDetailsCRUD.UpdateCartDetails();
            //ObjCartDetailsCRUD.GetCartDetails();
            //ObjCartDetailsCRUD.DeleteCartDetails();

            //now for OrderDetails
            OrderDetailsCRUD objOrderDetailsCRUD = new OrderDetailsCRUD();

            //
            /*OrderDetails neworderDetails = new OrderDetails
            {
                CartDetailsId = 11,
                OrderPaymentMode = "UPI",
                OrderTotalPrice = 100,
                OrderDeliveryStatus = "Inp"
            };

            objOrderDetailsCRUD.InsertOrderDetails(neworderDetails);*/

            //objOrderDetailsCRUD.InsertOrderDetails();
            //objOrderDetailsCRUD.GetOrderDetails();
            objOrderDetailsCRUD.UpdateOrderDetails();
            Console.ReadKey();
        }
    }
}