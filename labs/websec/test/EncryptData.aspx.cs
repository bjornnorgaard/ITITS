using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace test {
	public partial class EncryptData : System.Web.UI.Page
	{
        
        public static string Protect(string unprotectedText)
        {
            var unprotectedBytes = Encoding.UTF8.GetBytes(unprotectedText);
            var protectedBytes = MachineKey.Protect(unprotectedBytes, "Recipient: user");
            var protectedText = Convert.ToBase64String(protectedBytes);
            return protectedText;
        }

        public static string Unprotect(string protectedText)
        {
            var protectedBytes = Convert.FromBase64String(protectedText);
            var unprotectedBytes = MachineKey.Unprotect(protectedBytes, "Recipient: user");
            var unprotectedText = Encoding.UTF8.GetString(unprotectedBytes);
            return unprotectedText;
        }

        public static void Store(String encryptedData)
        {

            string MyConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=websecdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(MyConString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "insert into EncryptedBlobs (EncryptedData) values ('" + encryptedData + "')";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public static String Fetch(String id)
        {
            string MyConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=websecdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(MyConString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = "select  (EncryptedData) from EncryptedBlobs where id=" + id;
            connection.Open();
            SqlDataReader Reader;
            Reader = command.ExecuteReader();
            String returnValue = "";
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString();
                returnValue += (thisrow);
            }
            connection.Close();
            return returnValue;
        }


    }
}
