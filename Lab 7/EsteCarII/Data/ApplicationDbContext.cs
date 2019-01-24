using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using EsteCarII.Models;

namespace EsteCarII.Data
{
    public class ApplicationDbContext : IdentityDbContext<Cliente>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EsteCarII.Models.Carro> Carro { get; set; }
        public DbSet<EsteCarII.Models.Marca> Marca { get; set; }
        public DbSet<EsteCarII.Models.Aluguer> Aluguer { get; set; }
    }
}
