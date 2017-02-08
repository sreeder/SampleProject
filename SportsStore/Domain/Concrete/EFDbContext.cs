
using System.Data.Entity;
using Domain.Entitities;

namespace Domain.Concrete
{
    class EFDbContext : DbContext
    {
        public DbSet <Product> Products { get; set; }
    }
    
}
