using EstCarIIILibrary.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace EstCarIIILibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext<Cliente>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EstCarIIILibrary.Models.Carro> Carro { get; set; }
        public DbSet<EstCarIIILibrary.Models.Marca> Marca { get; set; }
        public DbSet<Aluguer> Aluguer { get; set; }
    }
}
