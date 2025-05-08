var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages(); // Enable Razor Pages (optional, but good for future use)

var app = builder.Build();

// Force HTTPS Redirection (Even in Development)
app.UseHttpsRedirection();
app.UseHsts();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Default Routing (Controllers)
app.MapDefaultControllerRoute();

// Razor Pages (optional)
app.MapRazorPages();

app.Run();
