using CafeShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CafeShop.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Cafe", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Tea", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Cookie", DisplayOrder = 3 }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Cà phê sữa đá",
                        Description = "Cà phê pha phin truyền thống với sữa đặc, vị đậm đà và béo ngậy.",
                        ProductCode = "CF001",
                        Size = "M",
                        ListPrice = 45000,
                        Price = 42000,
                        Price50 = 40000,
                        Price100 = 38000,
                        CategoryId = 1,
                        ImageUrl = ""
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Trà đào cam sả",
                        Description = "Trà đào tươi kết hợp cam vàng và sả, vị ngọt thanh mát.",
                        ProductCode = "TD001",
                        Size = "L",
                        ListPrice = 55000,
                        Price = 52000,
                        Price50 = 50000,
                        Price100 = 47000,
                        CategoryId = 2,
                        ImageUrl = ""
                    },
                     new Product
                     {
                         Id = 3,
                         Name = "Bánh tiramisu",
                         Description = "Bánh ngọt kiểu Ý với lớp kem mascarpone mềm mịn và cacao thơm lừng.",
                         ProductCode = "BK001",
                         Size = "M",
                         ListPrice = 65000,
                         Price = 62000,
                         Price50 = 60000,
                         Price100 = 57000,
                         CategoryId = 3,
                         ImageUrl = ""
                     },
                     new Product
                     {
                         Id = 4,
                         Name = "Trà vải hoa hồng",
                         Description = "Sự kết hợp tinh tế giữa vị ngọt của vải tươi và hương thơm quyến rũ của hoa hồng.",
                         ProductCode = "TC001",
                         Size = "L",
                         ListPrice = 59000,
                         Price = 56000,
                         Price50 = 54000,
                         Price100 = 51000,
                         CategoryId = 2,
                         ImageUrl = ""
                     },
                      new Product
                      {
                          Id = 5,
                          Name = "Trà ổi hồng",
                          Description = "Trà trái cây tươi mát với ổi hồng chín mọng, mang đến hương vị ngọt dịu tự nhiên.",
                          ProductCode = "TC002",
                          Size = "L",
                          ListPrice = 57000,
                          Price = 54000,
                          Price50 = 52000,
                          Price100 = 49000,
                          CategoryId = 2,
                          ImageUrl = ""
                      },
                      new Product
                      {
                          Id = 6,
                          Name = "Trà nhài đào ổi",
                          Description = "Trà nhài kết hợp vị ngọt thanh của đào và ổi, mang hương thơm dịu nhẹ và sảng khoái.",
                          ProductCode = "TC003",
                          Size = "L",
                          ListPrice = 60000,
                          Price = 57000,
                          Price50 = 55000,
                          Price100 = 52000,
                          CategoryId = 2,
                          ImageUrl = ""
                      }
                );
        }
    }
}
