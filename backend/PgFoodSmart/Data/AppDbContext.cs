// ---------------------------
// Data/AppDbContext.cs
// ---------------------------

using Microsoft.EntityFrameworkCore;
using PgFoodSmart.Models;

namespace PgFoodSmart.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<MealResponse> MealResponses => Set<MealResponse>();
        public DbSet<AlertLog> AlertLogs => Set<AlertLog>();
    }
}
