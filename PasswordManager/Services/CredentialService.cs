using PasswordManager.Models;

namespace PasswordManager.Services
{
    public class CredentialService : ICredentialService
    {
        private StorageContext _storageContext;

        public CredentialService(StorageContext storageContext)
        {
            _storageContext = storageContext;
        }

        public void CreateCredential(Credentials credentials)
        {
            _storageContext.Credentials.Add(credentials);
        }

        public void DeleteCredential(Guid credentialId)
        {
            _storageContext.Credentials.Where(id => id.Id == credentialId);
        }

        public List<Credentials> GetCredentials()
        {
            return _storageContext.Credentials.ToList();
        }

        public Credentials GetCredentialsById(Guid credentialId)
        {
            var credential = _storageContext.Credentials.Where(id => id.Id == credentialId).SingleOrDefault();

            if (credential == null)
            {
                throw new ArgumentNullException("No such credential found!");
            }

            return credential;
        }

        public void UpdateCredential(Guid credentialId, Credentials credentials)
        {
            Credentials credentialFound = GetCredentialsById(credentialId);

            credentialFound.UserName = credentials.UserName;
            credentialFound.Password = credentials.Password;
            credentialFound.ProtectionType = credentials.ProtectionType;

            _storageContext.Credentials.Update(credentialFound);
        }
    }
}
