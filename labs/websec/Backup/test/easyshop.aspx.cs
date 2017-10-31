
namespace test
{
	using System;
	using System.Web;
	using System.Web.UI;

	
	public partial class Easyshop : System.Web.UI.Page
	{
		protected String GetToken() {
			if (Session ["xsrftoken"] == null) {
				Session ["xsrftoken"] = System.Guid.NewGuid();
			}
			return Session ["xsrftoken"].ToString();
		}

	}


}