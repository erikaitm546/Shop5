
namespace Shop5.Web.Data

{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Shop5.Web.Data.Entities;

    public class DataContext : IdentityDbContext<User>

    {
        public DbSet<Product> Products { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }


    }
}
