
namespace test
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Web;
	using System.Web.UI;
	using System.Web.UI.WebControls;
	using System.Data;
	using System.Xml;
	
	public partial class Xxe : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected String getPage() {
			if (Request ["xml"] != null) {
				string OurOutputXMLString = Request ["xml"];
				XmlDocument xmlDoc = new XmlDocument ();
                xmlDoc.LoadXml (OurOutputXMLString);
				return xmlDoc.InnerText + " has been signed";
			} else { return "No input"; }
		}
	}
}

