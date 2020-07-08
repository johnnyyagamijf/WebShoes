using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebShoes.Infrastructure.Mapper;
using WebShoes.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using WebShoes.Infrastructure.IoC;

namespace WebShoes.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddMapper();
            services.ResolveDependencies();

            services.AddDbContext<WebShoesDataModelContext>(options => options.UseSqlServer("Data Source=localhost;Initial Catalog=WebShoesDb;Integrated Security=True"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
                        
            app.UseMvc();

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<WebShoesDataModelContext>();
                WebShoesEntitySeeder.Seed(context);
            }
        }
    }
}
    