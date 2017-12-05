using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DkHost : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

	protected String GetTXTRecord() {
		if (Session["name"] != null && !Session["name"].Equals(""))
		{
			return ("trustskills.dk. TXT " + Session["name"] + "<br>");
		}
		return "";
	}
}
