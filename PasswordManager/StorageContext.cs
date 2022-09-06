using Microsoft.EntityFrameworkCore;
using PasswordManager.Models;

namespace PasswordManager
{
    public class StorageContext : DbContext
    {
        public StorageContext(DbContextOptions<StorageContext> options) : base(options)
        {

        }

        public DbSet<Credentials> Credentials { get; set; }
    }
}
