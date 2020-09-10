using Microsoft.EntityFrameworkCore;
using Turkiz.Model;
using Turkiz.Models;

namespace Turkiz.Data
{
    public class ShenkinBagsContext :DbContext
    {
        public ShenkinBagsContext(DbContextOptions<ShenkinBagsContext> options) : base (options)
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}