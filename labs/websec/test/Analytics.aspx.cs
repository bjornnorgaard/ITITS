using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

	protected String getDBData() {
		String returnValue = "";
		if(Request["id"] != null) {
			Response.Write("<br><i>Latest updates: </i><br>");
			string MyConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=websecdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

			SqlConnection connection = new SqlConnection(MyConString);
			SqlCommand command = connection.CreateCommand();
			SqlDataReader Reader;
			command.CommandText = "select * from mycustomers WHERE id=" + Request["id"];
			connection.Open();
			Reader = command.ExecuteReader();
			while (Reader.Read())
			{
				string thisrow = "";
				for (int i= 0;i<Reader.FieldCount;i++)
					thisrow+=Reader.GetValue(i).ToString() + ",";
				returnValue += (thisrow + "<br/>");	
			}
			connection.Close();
		}
		return returnValue;
	}

}
