using Microsoft.AspNetCore.Mvc;
using PasswordManager.Services;

namespace PasswordManager.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CredentialsController: ControllerBase
    {
        private ICredentialService _credentialService;

        public CredentialsController(ICredentialService credentialService)
        {
            _credentialService = credentialService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var credentials = _credentialService.GetCredentials();
            return Ok(credentials);
        }        
    }
}
