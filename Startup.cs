using GraphQlDemo.Types;

namespace GraphQlDemo
{
    public class Startup
    {
        private IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection collection)
        {
            collection
                .AddGraphQLServer()
                .AddTypeExtension<ManufacturerType>()
                .AddTypeExtension<CarType>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();

            app.UseWebSockets();
            
            app.UseEndpoints(e =>
            {
                e.MapGraphQL();
            });

            app.UseSpa(s =>
            {
                s.Options.SourcePath = "ClientApp";
            });
        }
    }
}