using Loja_Virtual__MVC_.Models;
using Microsoft.EntityFrameworkCore;

namespace Loja_Virtual__MVC_.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) :base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Lanche> Lanches { get; set; }

    }
}
