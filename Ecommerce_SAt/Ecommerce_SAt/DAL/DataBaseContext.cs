using Ecommerce_SAt.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce_SAt.DAL
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) :base(options)
        {
            
        }
        // con esto se mapea  la entidad para poder crar la tabla "DbSet"
        public DbSet<Country> countries { get; set; }// las tablas se nombran en plural
        // vamos a crear un  un indice para la tabla countries
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }

}
