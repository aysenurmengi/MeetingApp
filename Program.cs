var builder = WebApplication.CreateBuilder(args);

//mvcyi projeye tanıttık
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles(); //statik dosyalarını aktif hale getirdik yani wwwroot altındakiler erişime açık
app.UseRouting();

//{controller=Home}/{action=index}/id?
//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
