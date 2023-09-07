using Microsoft.EntityFrameworkCore;
using WebApiEF.Models;

namespace WebApiEF.Data
{
    public class DBLibrosEFContext : DbContext
    {
        //tiene que estar el constructor con parámetro
        public DBLibrosEFContext(DbContextOptions<DBLibrosEFContext> options) : base(options) { }

        //Propiedades DBSET por Modelo
        public DbSet<Autor> Autor { get; set; }
        public DbSet<Libro> Libro { get; set; }

    }
}
