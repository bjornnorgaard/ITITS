using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace test {
	public partial class ClientSideCert : System.Web.UI.Page
	{
		protected String GetCCSubject() {
            HttpClientCertificate cs = Request.ClientCertificate;
			return cs.Subject;
		}

		
	}
}
