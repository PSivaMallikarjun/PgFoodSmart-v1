
// ---------------------------
// Models/User.cs
// ---------------------------

namespace PgFoodSmart.Models
{
    public class User
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public string ? Email { get; set; }
        public string ? PushToken { get; set; }
    }
}