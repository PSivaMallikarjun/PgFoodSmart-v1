// ---------------------------
// Models/AlertLog.cs
// ---------------------------

namespace PgFoodSmart.Models
{
    public class AlertLog
    {
        public int Id { get; set; }
        public string ? MealType { get; set; }
        public DateTime SentAt { get; set; }
    }
}

