using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JM.DataAccess;
using JM.Model;


namespace JioMartApp
{
    public partial class UserSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Signup_Click(object sender, EventArgs e)
        {
            //userInput.Text = UserName.Text;
            string UserFirstName = txtUserFirstName.Text;
            string UserLastName = txtUserLastName.Text;
            string UserEmail = txtUserEmail.Text;
            string UserMobileNo = txtUserMobileNo.Text;
            string UserPassword = txtPasssword.Text;
            string UserAddress = txtAddress.Text;

            UserDetailsCRUD userDetailsCRUD = new UserDetailsCRUD();
            userDetailsCRUD.InsertUserDetails(UserFirstName, UserLastName, UserEmail, UserMobileNo, UserPassword, UserAddress);

            Response.Redirect("Login.Aspx");
        }

        
    }
}