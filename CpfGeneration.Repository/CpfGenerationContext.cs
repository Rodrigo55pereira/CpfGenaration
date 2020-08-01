using CpfGeneration.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CpfGeneration.Repository.Data
{
    public class CpfGenerationContext : DbContext
    {
        public CpfGenerationContext(DbContextOptions<CpfGenerationContext> options) : base (options) {}

        public DbSet<Cliente> Clientes { get; set; }
    }
}