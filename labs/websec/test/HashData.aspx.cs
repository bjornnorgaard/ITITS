using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace test {
	public partial class HashData : System.Web.UI.Page
	{

        public static string Hash(string unprotectedText)
        {
            SHA256 sha256 = SHA256Managed.Create();
            var unhashedBytes = Encoding.UTF8.GetBytes(unprotectedText);
            var hashedBytes = sha256.ComputeHash(unhashedBytes);
            var hashedText = Convert.ToBase64String(hashedBytes);
            return hashedText;
        }


        public static void Store(String hashedData)
        {

            string MyConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=websecdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(MyConString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into HashedData (Checksum) values ({hashedData})";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }




    }
}
