using CpfGeneration.Domain;
using Microsoft.EntityFrameworkCore;

namespace CpfGeneration.Repository
{
    public class CpfGenerationContext : DbContext
    {
        public CpfGenerationContext(DbContextOptions<CpfGenerationContext> options) : base (options) {}

        public DbSet<Cliente> Clientes { get; set; }
    }
}