/*using Microsoft.Identity.Web;

namespace FirstTeamGraphApp
{
    public static class Startup
    {
        public static WebApplication InitializeApp(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            ConfigureServices(builder);
            var app = builder.Build();
            Configure(app);
            return app;
        }

      /*private static void ConfigureServices(WebApplicationBuilder builder)
        {
            builder.Services.AddRazorPages();
        }
        public static void ConfigureServices(WebApplicationBuilder builder)
        {
            // Use Web API authentication (default JWT bearer token scheme)
            builder.Services.AddMicrosoftIdentityWebApiAuthentication(builder.Configuration)
                // Enable token acquisition via on-behalf-of flow
                .EnableTokenAcquisitionToCallDownstreamApi()
                // Specify that the down-stream API is Graph
                .AddMicrosoftGraph(builder.Configuration.GetSection("Graph"))
                // Use in-memory token cache
                // See https://github.com/AzureAD/microsoft-identity-web/wiki/token-cache-serialization
                .AddInMemoryTokenCaches();

            builder.Services.AddRazorPages();
            builder.Services.AddControllers();
            builder.Services.AddAuthentication();
            builder.Services.AddAuthorization();
            builder.Services.AddRouting();
            //builder.Services.AddStaticFiles();
        }

        private static void Configure(WebApplication app)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.MapRazorPages();

            app.MapControllers();
            app.UseWebSockets();
        }
    }
}
*/