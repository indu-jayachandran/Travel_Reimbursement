using Microsoft.EntityFrameworkCore;
using Serilog;

 var builder = WebApplication.CreateBuilder(args);
 builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();
});

builder.Services.AddControllersWithViews();

var configuration = builder.Configuration;

builder.Services.AddDbContext<BillingContext>(options =>
    options.UseSqlServer(configuration.GetConnectionString("DefaultConnections")));
builder.Services.AddHttpContextAccessor();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(5);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var _logger=new LoggerConfiguration().
WriteTo.File("C:\\Users\\INDUJA\\OneDrive\\Desktop\\entityframe\\appDup1\\Travel\\Application\\Logger-.log",rollingInterval:RollingInterval.Day).CreateLogger();
 builder.Logging.AddSerilog(_logger);

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
app.UseSession();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

