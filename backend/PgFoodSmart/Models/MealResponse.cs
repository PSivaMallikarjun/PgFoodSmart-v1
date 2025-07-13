
// ---------------------------
// Models/MealResponse.cs
// ---------------------------

namespace PgFoodSmart.Models
{
    public class MealResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ? MealType { get; set; } // Dinner, Tiffin, Lunch
        public DateTime ResponseDate { get; set; }
        public bool WillAttend { get; set; }
    }
}