using AtPetShop.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace AtPetShop.Data
{
    public class PetShopContext : DbContext
    {
        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShelfLocation> ShelfLocation { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShelfLocation>().HasData(
                new ShelfLocation()
                {
                    Id = 1,
                    Row = 4,
                    Column = 3,
                    Aisle = 6,
                    Created = DateTime.Now,
                },
                new ShelfLocation()
                {
                    Id = 2,
                    Row = 5,
                    Column = 1,
                    Aisle = 7,
                    Created = DateTime.Now,
                },
                new ShelfLocation()
                {
                    Id = 3,
                    Row = 12,
                    Column = 6,
                    Aisle = 9,
                    Created = DateTime.Now,
                }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Vestido para gato",
                    ShortDescription = "Vestido rosa",
                    Description = "Vestido rosa para gatos filhotes, tecido sem estampa",
                    Price = 45,
                    Category = "Roupa",
                    ImageFile = "pinkDress.jpg",
                    Created = DateTime.Now,
                    ShelfLocationId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Antipulgas",
                    ShortDescription = "Antipulgas Simparic 20 mg para cães 5,1 a 10 kg - Zoetis",
                    Description = "Indicado para cães de 5,1 a 10 kg. Proteção contra pulgas, carrapatos, sarnas. Comprimido mastigável",
                    Price = 95.69M,
                    Category = "Farmácia",
                    ImageFile = "antipulgas.jpg",
                    Created = DateTime.Now,
                    ShelfLocationId = 2,
                },
                new Product()
                {
                    Id = 3,
                    Name = "Comedouro",
                    ShortDescription = "Comedouro Chalesco Duplo Inox para Cães",
                    Description = "Recipiente amplo e limpo. Disponível nos tamanhos 2, 3 e 4.",
                    Price = 59.99M,
                    Category = "Acessórios de Alimentação",
                    ImageFile = "comedouro.jpg",
                    Created = DateTime.Now,
                    ShelfLocationId = 3,
                }
            );
        }
    }
}
