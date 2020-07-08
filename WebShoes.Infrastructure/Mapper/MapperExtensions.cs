using Microsoft.Extensions.DependencyInjection;

namespace WebShoes.Infrastructure.Mapper
{
    public static class MapperExtensions
    {
        public static void AddMapper(this IServiceCollection serviceCollection)
        {
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            var mapper = config.CreateMapper();
            serviceCollection.AddSingleton(mapper);
        }
    }
}
