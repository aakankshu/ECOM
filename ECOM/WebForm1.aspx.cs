using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ECOM
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                Label1.Text = ("Your purchase history has been revised!");
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection ecom_conn = new SqlConnection("Server=tcp:ecomdb29.database.windows.net,1433;Initial Catalog=ecomdb;Persist Security Info=False;User ID=aakankshu;Password=ecomdb@29;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.InsertFullName @FullName", ecom_conn);
                insert.Parameters.AddWithValue("@FullName", TextBox1.Text);

                ecom_conn.Open();
                insert.ExecuteNonQuery();
                ecom_conn.Close();

                if (IsPostBack)
                {
                    TextBox1.Text = "";
                }
            }
        }
    }
}