using JM.DataAccess;
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

            //Insert user Details
            //objUserDetailsCRUD.InsertUserDetails();

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
            ObjCartDetailsCRUD.InsertCartDetails();
            //ObjCartDetailsCRUD.UpdateCartDetails();
            //ObjCartDetailsCRUD.GetCartDetails();
            //ObjCartDetailsCRUD.DeleteCartDetails();
            Console.ReadKey();
        }
    }
}