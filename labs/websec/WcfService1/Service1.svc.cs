using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Cryptography;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public Token Login()
        {
            var jwt = new JwtSecurityToken(
                issuer: "test",
                audience: "test",
                claims: new Claim[] { new Claim(ClaimTypes.Role, "Admin"), new Claim(ClaimTypes.Name, "Anders") },
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddDays(7),
                signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(new byte[256]), Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            return new Token { token = encodedJwt };
        }

        public Bearer Claims()
        {
            TokenValidationParameters valPar = new TokenValidationParameters
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                IssuerSigningKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(new byte[256])
            };
            Microsoft.IdentityModel.Tokens.SecurityToken token = null;
            IncomingWebRequestContext request = WebOperationContext.Current.IncomingRequest;
            WebHeaderCollection headers = request.Headers;
            var encodedJwt = new JwtSecurityTokenHandler().ValidateToken(headers["Authorization"].Replace("Bearer ", ""), valPar, out token);

            return new Bearer { bearer = encodedJwt.Identity.Name.ToString() };
        }

        public Token Register(RequestData req)
        {
            Store(Hash(req.username));
            var jwt = new JwtSecurityToken(
                issuer: "test",
                audience: "test",
                claims: new Claim[] { new Claim(ClaimTypes.Role, "Admin"), new Claim(ClaimTypes.Name, req.username) },
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddDays(7),
                signingCredentials: new Microsoft.IdentityModel.Tokens.SigningCredentials(new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(new byte[256]), Microsoft.IdentityModel.Tokens.SecurityAlgorithms.HmacSha256Signature));
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            return new Token { token = encodedJwt };
        }

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

            string MyConString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=websecdb;Integrated Security=True;Connect Timeout=3;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            SqlConnection connection = new SqlConnection(MyConString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = $"insert into HashedData (Checksum) values ('{hashedData}')";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
    public class Token
    {
        public String token;
    }
    public class Bearer
    {
        public String bearer;
    }
}
