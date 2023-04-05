using itlapr.Web.ApiServices.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// This method gets called by the runtime. Use this method to add services to the container.
 void ConfigureServices(IServiceCollection services)
{
    services.AddHttpClient();
    services.AddTransient<IEmployeesApiServices, IEmployeesApiServices>();
    services.AddControllersWithViews();

}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
