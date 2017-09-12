using Microsoft.AspNetCore.Mvc;

namespace Encryption.Controllers
{
    [Route("api/v1/encryption")]
    public class EncryptionController : Controller
    {
        [HttpGet]
        public string Get()
        {
            return "API is working";
        }

        [HttpGet("encrypt/{plaintext}")]
        public string Get(int plaintext)
        {
            return $"Received: {plaintext}";
        }
    }
}
