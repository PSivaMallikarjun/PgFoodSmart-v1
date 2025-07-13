
// ---------------------------
// Services/IMealService.cs
// ---------------------------

using PgFoodSmart.Models;

namespace PgFoodSmart.Services
{
    public interface IMealService
    {
        Task SaveResponse(MealResponse response);
        Task<IEnumerable<MealResponse>> GetDailyReport(DateTime date);
    }
}