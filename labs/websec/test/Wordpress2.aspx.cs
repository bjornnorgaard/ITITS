
namespace test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Data;
    using System.Web.Security;
    using System.Data.SqlClient;

    public partial class Wordpress2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}



		protected String getPage() {
			String returnValue = "";
			if(Request["username"] != null) {

                string MyConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=websecdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

                SqlConnection connection = new SqlConnection(MyConString);
				SqlCommand command = connection.CreateCommand();
				SqlDataReader Reader;

				command.CommandText = "select * from Users WHERE username='" + Request["username"] + "' AND password='" + FormsAuthentication.HashPasswordForStoringInConfigFile(Request["pwd"], "MD5") + "'";
				connection.Open();
				bool nothing = true;
				try
				{
					Reader = command.ExecuteReader();


					while (Reader.Read())
					{
						nothing = false;
						returnValue = ("Password incorrect.");
						break;
					}

				}
				catch {}
				connection.Close();
				if (nothing)
				{
					returnValue = ("Login error.");
				}
			}
			return returnValue;
		}
	}
}

