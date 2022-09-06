using Microsoft.EntityFrameworkCore;

namespace Stone0309.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }
    }
}
