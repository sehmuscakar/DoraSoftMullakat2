using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete.Context
{
    public class ProjeContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<HomeMenu> HomeMenus { get; set; }
        public DbSet<TopCategory> TopCategories { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategoory> SubCategoories { get; set; }
        public DbSet<ContactCompany> ContactCompanies { get; set; }
     
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)// overide on yaz gelir
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PBFD0LU;  database=DoraSoftmulakat2; integrated security=true; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder builder) // fluent api ile ilişkilerimiz yapılandırdık.
        {
            builder.Entity<SubMenu>(entity => // çoklu üzerinden ilerle 
            {

                entity.HasOne(x => x.Menu).WithMany(x => x.SubMenus).HasForeignKey(x => x.MenuId);
            });

            builder.Entity<SubCategoory>(entity =>
            {
                entity.HasOne(x => x.TopCattegory).WithMany(x => x.SubCategoories).HasForeignKey(x => x.TopCattegoryId);
                entity.HasOne(x => x.Cattegory).WithMany(x => x.SubCategoories).HasForeignKey(x => x.CattegoryId);
            
            });

            builder.Entity<Category>(entity => // çoklu üzerinden ilerle 
            {
        
                entity.HasOne(x => x.TopCattegory).WithMany(x => x.Categories).HasForeignKey(x => x.TopCattegoryId);

            });

            base.OnModelCreating(builder);
        }

    }
}
