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
        public DbSet<Cuenta> Cuentas { get; set; }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Tipo> Tipos { get; set; }

        //Creamos indices para evitar que se dupliquen los datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Cuenta>().HasIndex(x => new { x.EmpresaId, x.Codigo }).IsUnique();
            modelBuilder.Entity<Empresa>().HasIndex(x => x.Nit).IsUnique();
            modelBuilder.Entity<Tipo>().HasIndex(x => x.Name).IsUnique();
        }
    }
}