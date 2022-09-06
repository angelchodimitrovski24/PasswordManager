using PasswordManager.Models;

namespace PasswordManager.Services
{
    public interface ICredentialService
    {
        List<Credentials> GetCredentials();

        Credentials GetCredentialsById(Guid credentialId);

        void CreateCredential(Credentials credentials);

        void UpdateCredential(Guid credentialId, Credentials credentials);

        void DeleteCredential(Guid credentialId);
    }
}
