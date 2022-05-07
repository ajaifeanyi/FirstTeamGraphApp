//using FirstTeamGraphApp;
using Microsoft.Identity.Web;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => options.AddPolicy("allowAny", o => o.AllowAnyOrigin()));
builder.Services.AddMicrosoftIdentityWebApiAuthentication(builder.Configuration)
    .EnableTokenAcquisitionToCallDownstreamApi()
    .AddMicrosoftGraph(builder.Configuration.GetSection("Graph"))
    .AddInMemoryTokenCaches();

builder.Services.AddAuthorization();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
 if(!app.Environment.IsDevelopment())
{
        app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
       app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseCors();

app.UseAuthentication();

app.UseStaticFiles();

 app.UseRouting();

 app.UseAuthorization();

 app.MapRazorPages();

app.MapControllers();

app.Run();


