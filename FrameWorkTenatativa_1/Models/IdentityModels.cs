using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FrameWorkTenatativa_1.Models
{
    // É possível adicionar dados do perfil do usuário adicionando mais propriedades na sua classe ApplicationUser, visite https://go.microsoft.com/fwlink/?LinkID=317594 para obter mais informações.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Observe que o authenticationType deve corresponder àquele definido em CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Adicionar declarações de usuário personalizado aqui
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("fwork_01", throwIfV1Schema: false)
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


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}