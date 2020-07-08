using Microsoft.Extensions.DependencyInjection;
using WebShoes.Application.Contracts.Services;
using WebShoes.Application.Services;
using WebShoes.Core.Contracts.Repositories;
using WebShoes.Core.Contracts.Services;
using WebShoes.Core.Services;
using WebShoes.Infrastructure.Data.Repositories;

namespace WebShoes.Infrastructure.IoC
{
    public static class IoCExtensions
    {
        public static void ResolveDependencies(this IServiceCollection serviceCollection)
        {
            // Product
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();
            serviceCollection.AddScoped<IProductAppService, ProductAppService>();
            serviceCollection.AddScoped<IProductService, ProductService>();

            // Request
            serviceCollection.AddScoped<IRequestRepository, RequestRepository>();
            serviceCollection.AddScoped<IRequestAppService, RequestAppService>();
            serviceCollection.AddScoped<IRequestService, RequestService>();
        }
    }
}
