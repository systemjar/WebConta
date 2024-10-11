using Microsoft.EntityFrameworkCore;
using WebConta.Shared.Entities;

namespace WebConta.Backend.Data
{
    //Esta clase hereda de DbContext
    public class DataContext : DbContext
    {
        //Esto es para conectarse a la base de datos
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        //El DbSet se pone en plural del nombre de la tabla
        public DbSet<Tipo> Tipos { get; set; }

        //Creamos indices para evitar que se dupliquen los datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tipo>().HasIndex(x => x.Name).IsUnique();
        }
    }
}
