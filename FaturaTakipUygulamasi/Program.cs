
using FaturaTakipUygulamasi.Abstracts;
using FaturaTakipUygulamasi.Data;
using FaturaTakipUygulamasi.Mappers;
using FaturaTakipUygulamasi.Models;
using FaturaTakipUygulamasi.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// dbcontext sýnýfýmýzý container a ekliyoruz ki dependency injection ile kullanabilelim.
builder.Services.AddDbContext<FaturaDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FaturaConnection")));

// Identity için gerekli olan sýnýflarý ekliyoruz.
builder.Services.AddDefaultIdentity<Uye>()
    .AddEntityFrameworkStores<FaturaDbContext>();

// automapper sýnýfýný ekliyoruz.
builder.Services.AddAutoMapper(typeof(ProjectMapper));

// repository sýnýflarýný ekliyoruz. interface i çaðýrdýðýmda bana repository sýnýfýný versin.
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
    pattern: "{controller=Auth}/{action=Login}/{id?}"); // default route olarak Auth controller ý ve Login action ý ayarlandý.

app.Run();
