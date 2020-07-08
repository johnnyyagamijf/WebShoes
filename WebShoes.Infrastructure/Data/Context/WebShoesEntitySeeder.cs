using System.Collections.Generic;
using System.Linq;
using WebShoes.Core.Entities;

namespace WebShoes.Infrastructure.Data.Context
{
    public class WebShoesEntitySeeder
    {
        public static void Seed(WebShoesDataModelContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Products.Any())
            {
                var products = new List<ProductEntity>
                {
                    new ProductEntity { Name = "Sapato", Amount = 10, Value = 200},
                    new ProductEntity { Name = "Sapato Cinza", Amount = 10, Value = 300},
                    new ProductEntity { Name = "Sapato Preto", Amount = 10, Value = 400}
                };

                context.Products.AddRange(products);
                context.SaveChanges();
            }
        }
    }
}
