var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();
//app.MapControllerRoute(name: "default", pattern: "{controller=Product}/{action=Index}/{id?}");

//app.MapControllerRoute(name: "default", pattern: "{controller=Book}/{action=Index}/{id?}");
//app.MapControllerRoute(name: "default", pattern: "{controller=Employee}/{action=Index}/{id?}");
app.MapControllerRoute(name: "default", pattern: "{controller=User}/{action=Index}/{id?}");
app.Run();

