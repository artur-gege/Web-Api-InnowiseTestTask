using Microsoft.EntityFrameworkCore;
using WEB_API_Innowise_TestTask.Models;

namespace WEB_API_Innowise_TestTask.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public DbSet<Fridge> Fridges { get; set; }
        public DbSet<FridgeModel> FridgeModels { get; set; }
        public DbSet<FridgeProducts> FridgesProducts { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fridge>()
                .ToTable("Fridges")
                .HasData(
                    new Fridge { Id = 1, Name = "Kitchen Fridge", OwnerName = "John Doe", FridgeModelId = 1 },
                    new Fridge { Id = 2, Name = "Cellar Fridge", OwnerName = "Jane Smith", FridgeModelId = 2 },
                    new Fridge { Id = 3, Name = "Garage Fridge", OwnerName = "Bob Johnson", FridgeModelId = 3 }
                );

            modelBuilder.Entity<FridgeModel>()
                .ToTable("FridgeModels")
                .HasData(
                    new FridgeModel { Id = 1, Name = "Samsung RF28R7551SR", Year = 2020 },
                    new FridgeModel { Id = 2, Name = "LG LFXS28968S", Year = 2021 },
                    new FridgeModel { Id = 3, Name = "ATLANT GNE29GMHES", Year = 2022 }
                );

            modelBuilder.Entity<FridgeProducts>()
                .ToTable("FridgesProducts")
                .HasData(
                    new FridgeProducts { Id = 1, FridgeId = 1, ProductId = 1, Quantity = 5 },
                    new FridgeProducts { Id = 2, FridgeId = 1, ProductId = 2, Quantity = 3 },
                    new FridgeProducts { Id = 3, FridgeId = 1, ProductId = 3, Quantity = 10 },
                    new FridgeProducts { Id = 4, FridgeId = 1, ProductId = 4, Quantity = 2 },
                    new FridgeProducts { Id = 5, FridgeId = 1, ProductId = 5, Quantity = 6 },
                    new FridgeProducts { Id = 6, FridgeId = 2, ProductId = 6, Quantity = 12 },
                    new FridgeProducts { Id = 7, FridgeId = 2, ProductId = 7, Quantity = 8 },
                    new FridgeProducts { Id = 8, FridgeId = 2, ProductId = 8, Quantity = 4 },
                    new FridgeProducts { Id = 9, FridgeId = 2, ProductId = 9, Quantity = 3 },
                    new FridgeProducts { Id = 10, FridgeId = 3, ProductId = 10, Quantity = 15 },
                    new FridgeProducts { Id = 11, FridgeId = 3, ProductId = 11, Quantity = 10 },
                    new FridgeProducts { Id = 12, FridgeId = 3, ProductId = 12, Quantity = 7 }
                );

            modelBuilder.Entity<Product>()
                .ToTable("Products")
                .HasData(
                    new Product { Id = 1, Name = "Apple", Price = 1.99 },
                    new Product { Id = 2, Name = "Orange", Price = 2.99 },
                    new Product { Id = 3, Name = "Banana", Price = 0.99 },
                    new Product { Id = 4, Name = "Carrot", Price = 0.79 },
                    new Product { Id = 5, Name = "Onion", Price = 0.69 },
                    new Product { Id = 6, Name = "Potato", Price = 0.49 },
                    new Product { Id = 7, Name = "Egg", Price = 0.29 },
                    new Product { Id = 8, Name = "Milk", Price = 3.99 },
                    new Product { Id = 9, Name = "Cheese", Price = 4.99 },
                    new Product { Id = 10, Name = "Chicken", Price = 6.99 },
                    new Product { Id = 11, Name = "Beef", Price = 7.99 },
                    new Product { Id = 12, Name = "Pork", Price = 5.99 }
                ); 
        }
    }
}
