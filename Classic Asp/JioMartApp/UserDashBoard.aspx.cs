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
    public partial class UserDashBoard : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductDetailsCRUD productDetailsCRUD = new ProductDetailsCRUD();
            grid1.DataSource = productDetailsCRUD.getProducts();
            // Bind the data to the GridView
            grid1.DataBind();


            Repeater1.DataSource = productDetailsCRUD.getProducts1();
            Repeater1.DataBind();

        }

    }
}