
using FaturaTakipUygulamasi.Abstracts;
using FaturaTakipUygulamasi.Data;
using FaturaTakipUygulamasi.Mappers;
using FaturaTakipUygulamasi.Models;
using FaturaTakipUygulamasi.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// dbcontext s�n�f�m�z� container a ekliyoruz ki dependency injection ile kullanabilelim.
builder.Services.AddDbContext<FaturaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FaturaConnection")));

// Identity i�in gerekli olan s�n�flar� ekliyoruz.
builder.Services.AddDefaultIdentity<Uye>()
    .AddEntityFrameworkStores<FaturaDbContext>();

// automapper s�n�f�n� ekliyoruz.
builder.Services.AddAutoMapper(typeof(ProjectMapper));

// repository s�n�flar�n� ekliyoruz. interface i �a��rd���mda bana repository s�n�f�n� versin.
builder.Services.AddTransient<IAuthRepository, AuthRepository>();
builder.Services.AddTransient<IFaturaRepository, FaturaRepository>();
builder.Services.AddTransient<IMusteriRepository, MusteriRepository>();
builder.Services.AddTransient<IUrunRepository, UrunRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

// Authentication ve Authorization middlewarelerini ekliyoruz.
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Login}/{id?}"); // default route olarak Auth controller � ve Login action � ayarland�.

app.Run();
