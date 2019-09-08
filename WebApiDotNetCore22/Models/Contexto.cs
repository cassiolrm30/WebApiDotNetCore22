using Microsoft.EntityFrameworkCore;

namespace WebApiDotNetCore22.Models
{
    public class Contexto : DbContext 
    {
        public Contexto(DbContextOptions<Contexto> options)
            : base(options)
        {
            //Default
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}