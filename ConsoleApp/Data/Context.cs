using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Data
{
    public class Context: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public Context() 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.88.100;Database=TestForWork;User id=sa;password=SJ=V?mB1;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=false;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var categories = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Title = "Еда",
                },
                new Category
                {
                    Id = 2,
                    Title = "Молочка",
                },
                new Category
                {
                    Id = 3,
                    Title = "Электроника",
                }
            };

            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Title = "Хлеб",
                },
                new Product
                {
                    Id = 2,
                    Title = "Йогурт",
                },
                new Product
                {
                    Id = 3,
                    Title = "Шоколад",
                },
                new Product
                {
                    Id = 4,
                    Title = "Видеокарта",
                },
                new Product
                {
                    Id = 5,
                    Title = "Бочка",
                }
            };

            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Product>().HasData(products);


            modelBuilder
                .Entity<Product>()
                .HasMany(p => p.Categories)
                .WithMany(c => c.Products)
                .UsingEntity(c => c.HasData(
                    new
                    {
                        CategoriesId = 1,
                        ProductsId = 1,
                    },
                    new
                    {
                        CategoriesId = 1,
                        ProductsId = 2,
                    },
                    new
                    {
                        CategoriesId = 2,
                        ProductsId = 2,
                    },
                    new
                    {
                        CategoriesId = 1,
                        ProductsId = 3,
                    },
                    new
                    {
                        CategoriesId = 3,
                        ProductsId = 4,
                    }))
                ;

            base.OnModelCreating(modelBuilder);
        }
    }
}
