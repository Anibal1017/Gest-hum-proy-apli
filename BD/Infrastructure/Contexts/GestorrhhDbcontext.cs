using gestor_de_rh01.BD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace gestor_de_rh01.BD.Infrastructure.Contexts
{
    public interface IGestorrhhDbcontext
    {

        // F
        public DbSet<GestorRhh> GestorRhhs { get; set; }
        public DbSet<Loginrh> Loginrhs { get; set; }
        public DbSet<Personalrhh> Personalrhhs { get; set; }
        public DbSet<TelegramaEn> TelegramaEns { get; set; }
        public DbSet<Listacompra> Listcompras { get; set; }
        //public DbSet<Personal> Personal { get; set; }
        // public DbSet<Personal> Personal { get; set; }
       // public DbSet<Personal> Personal { get; set; }
        
        int SaveChanges();
    }
    public class GestorrhhDbcontext : DbContext, IGestorrhhDbcontext 
    {
        //f
        public DbSet<GestorRhh> GestorRhhs { get; set; }
        public DbSet<Loginrh> Loginrhs { get; set; }
        public DbSet<Personalrhh> Personalrhhs { get; set; }
        public DbSet<TelegramaEn> TelegramaEns { get; set; }
        public DbSet<Listacompra> Listcompras { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=GestorRhh.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
