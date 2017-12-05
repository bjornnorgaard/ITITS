
namespace test
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.UI;
	using System.Web.UI.WebControls;
	using MySql.Data.MySqlClient;
	using System.Data;
	using System.Web.Security;
	
	public partial class Wordpress2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected String getPage() {
			String returnValue = "";
			if(Request["username"] != null) {

				string MyConString = "SERVER=localhost;" +
					"DATABASE=mydatabase;" +
					"UID=certman;" +
					"PASSWORD=Test1234;";
				MySqlConnection connection = new MySqlConnection(MyConString);
				MySqlCommand command = connection.CreateCommand();
				MySqlDataReader Reader;

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

