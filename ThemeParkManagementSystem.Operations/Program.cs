using ThemeParkManagementSystem.Services.DataContext;
using Microsoft.EntityFrameworkCore;
using ThemeParkManagementSystem.Services;

var builder = WebApplication.CreateBuilder(args);

// Configures Entity Framework Core with SQLite
builder.Services.AddDbContext<TPMSDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SqlConn")));

// Register application services for dependency injection
builder.Services.AddScoped<ITicketServices, TicketSQLRepository>();
builder.Services.AddScoped<IRideServices, RideSQLRepository>();
builder.Services.AddScoped<IAnalyticsService, AnalyticsService>();


builder.Services.AddControllersWithViews();

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
