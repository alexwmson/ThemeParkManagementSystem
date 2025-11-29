using ThemeParkManagementSystem.Services.DataContext;
using Microsoft.EntityFrameworkCore;
using ThemeParkManagementSystem.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ITicketServices, TicketSQLRepository>();

builder.Services.AddControllersWithViews();

// DbContext
builder.Services.AddDbContext<TPMSDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
