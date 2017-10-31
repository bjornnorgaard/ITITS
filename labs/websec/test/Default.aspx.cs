using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace test {
	public partial class Default : System.Web.UI.Page
	{
		protected String GetLang() {
			return Request["lang"];
		}

		protected String GetDebugId() {
			return Server.HtmlEncode(Request["debugid"]);
		}
	}
}
