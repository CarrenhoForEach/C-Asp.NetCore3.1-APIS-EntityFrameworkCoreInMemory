using Microsoft.EntityFrameworkCore;
using lanchonete.Models;

namespace lanchonete.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {

        }

        public DbSet<Ingredientes> Ingrediente {get; set;} 
        public DbSet<Lanches> Lanche { get; set; }
    }
}