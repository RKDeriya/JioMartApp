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
    public partial class login : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void login_Click(object sender, EventArgs e)
        {
            //userInput.Text = UserName.Text;
            //UserDetailsCRUD objuserDetailsCRUD = new UserDetailsCRUD();
            //objuserDetailsCRUD.UserAuthentication();

            string UserEmail = email.Text;
            string UserPassword = pass.Text;

            UserDetailsCRUD objuserDetailsCRUD = new UserDetailsCRUD();
            bool exist = objuserDetailsCRUD.UserAuthentication(UserEmail,UserPassword,out string message);
            if (exist)
            {
                Session["useremail"] = UserEmail;
                Response.Redirect("UserDashBoard.aspx");
            }
            else
            {
                errorlbl.Text = message;
            }
        }
    }

 }

