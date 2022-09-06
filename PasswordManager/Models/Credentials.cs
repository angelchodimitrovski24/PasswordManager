using Microsoft.AspNetCore.Components.Routing;
using PasswordManager.Shared;

namespace PasswordManager.Models
{
    public class Credentials : Base
    {
        public string UserName { get; set; }

        public string Password { get; set; }     

        public ProtectionType ProtectionType { get; set; }
    }    
}
