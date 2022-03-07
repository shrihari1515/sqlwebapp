using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                Label1.Text = ("great");
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection storm = new SqlConnection("Server=tcp:hari12345.database.windows.net,1433;Initial Catalog=hari123456;Persist Security Info=False;User ID=hari;Password=Giri@20052005;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insert = new SqlCommand("EXEC dbo.InsertFullname @Fullname", storm);
                insert.Parameters.AddWithValue("@Fullname", TextBox1.Text);
                storm.Open();
                insert.ExecuteNonQuery();
                storm.Close();
                if (IsPostBack)
                {
                    TextBox1.Text = "";
                }
            }


        }
    }
}
