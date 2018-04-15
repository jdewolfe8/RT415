using RT410v3.Domain.Entities;
using System.Data.Entity;

namespace RT410v3.Domain.Concrete {

    public class EFDbContext : DbContext {
        public DbSet<Product> Products { get; set; }
    }
}