using Microsoft.EntityFrameworkCore;
using WebShoes.Core.Entities;
using WebShoes.Infrastructure.Data.Configuration;

namespace WebShoes.Infrastructure.Data.Context
{
    public class WebShoesDataModelContext : DbContext
    {
        public WebShoesDataModelContext(DbContextOptions<WebShoesDataModelContext> options)
            : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<RequestEntity> Requests { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProductConfig());
            builder.ApplyConfiguration(new RequestConfig());
        }
    }
}
