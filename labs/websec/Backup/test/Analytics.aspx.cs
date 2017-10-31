using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

	protected String getDBData() {
		String returnValue = "";
		if(Request["id"] != null) {
			Response.Write("<br><i>Latest updates: </i><br>");
			string MyConString = "SERVER=localhost;" +
				"DATABASE=mydatabase;" +
				"UID=certman;" +
				"PASSWORD=Test1234;";

			MySqlConnection connection = new MySqlConnection(MyConString);
			MySqlCommand command = connection.CreateCommand();
			MySqlDataReader Reader;
			command.CommandText = "select * from mycustomers WHERE idmycustomers=" + Request["id"];
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
