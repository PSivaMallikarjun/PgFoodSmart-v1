using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PgFoodSmart.Data;
using PgFoodSmart.Services;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// ----------------------------
// Service Registration
// ----------------------------

builder.Services.AddControllers();

// Register SQLite with EF Core
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Register app services
builder.Services.AddScoped<IMealService, MealService>();

// Swagger for API testing
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ?? Localization (All Indian languages + English)
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

var supportedCultures = new[]
{
    new CultureInfo("en"), // English
    new CultureInfo("hi"), // Hindi
    new CultureInfo("te"), // Telugu
    new CultureInfo("ta"), // Tamil
    new CultureInfo("kn"), // Kannada
    new CultureInfo("ml"), // Malayalam
    new CultureInfo("mr"), // Marathi
    new CultureInfo("gu"), // Gujarati
    new CultureInfo("bn"), // Bengali
    new CultureInfo("pa"), // Punjabi
    new CultureInfo("or"), // Odia
    new CultureInfo("ur")  // Urdu
};

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    options.DefaultRequestCulture = new RequestCulture("en");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

// ----------------------------
// Build & Pipeline
// ----------------------------

var app = builder.Build();

// ?? Enable localization
app.UseRequestLocalization(app.Services
    .GetRequiredService<Microsoft.Extensions.Options.IOptions<RequestLocalizationOptions>>().Value);

// Enable Swagger always
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

// ? Root route for basic check
app.MapGet("/", () => Results.Ok("? PG FoodSmart API is running. Visit /swagger to explore."));

app.Run();
