using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.IdentityModel.Tokens;
using System.Data.SqlClient;
using System.Runtime.Serialization;
using System.Security.Claims;
using System.Security.Cryptography;
using System.ServiceModel;
using System.Text;
namespace WebAPIDemo
{
    public class DemoController : ApiController
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

        public Token Register([FromBody]string req)
        {
            Store(Hash(req));
            var jwt = new JwtSecurityToken(
                issuer: "test",
                audience: "test",
                claims: new Claim[] { new Claim(ClaimTypes.Role, "Admin"), new Claim(ClaimTypes.Name, req) },
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
            command.CommandText = "insert into HashedData (Checksum) values ('" + hashedData + "')";
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }


      



        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
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
