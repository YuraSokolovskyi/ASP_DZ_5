using ASP_DZ_5;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddScoped<GettimesuniversalController>();

var app = builder.Build();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Gettimesuniversal}/{action=GetUtcTimes}/{id?}");

app.Run();
