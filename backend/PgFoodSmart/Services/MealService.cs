// ---------------------------
// Services/MealService.cs
// ---------------------------

using Microsoft.EntityFrameworkCore;
using PgFoodSmart.Data;
using PgFoodSmart.Models;

namespace PgFoodSmart.Services;

public class MealService(AppDbContext context) : IMealService
{
    public async Task SaveResponse(MealResponse response)
    {
        context.MealResponses.Add(response);
        await context.SaveChangesAsync();
    }

    public async Task<IEnumerable<MealResponse>> GetDailyReport(DateTime date)
    {
        return await context.MealResponses
            .Where(r => r.ResponseDate.Date == date.Date)
            .ToListAsync();
    }
}
