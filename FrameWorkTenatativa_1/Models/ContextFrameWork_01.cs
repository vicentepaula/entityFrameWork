using System.Data.Entity;

namespace FrameWorkTenatativa_1.Models
{
    public class ContextFrameWork_01 : DbContext
    {

        public ContextFrameWork_01() : base("fwork_01")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   /*
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().ToTable("City", "usutreino".ToUpper());
            modelBuilder.Entity<Departaments>().ToTable("Departaments", "usutreino".ToUpper());
            */
         //   modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("usu01".ToUpper());

        }

        public System.Data.Entity.DbSet<FrameWorkTenatativa_1.Models.Departaments> Departaments { get; set; }

        public System.Data.Entity.DbSet<FrameWorkTenatativa_1.Models.City> Cities { get; set; }
    }
}