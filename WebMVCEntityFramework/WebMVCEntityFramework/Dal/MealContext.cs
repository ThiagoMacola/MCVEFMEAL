using System.Data.Entity;
using WebMVCEntityFramework.Models;

namespace WebMVCEntityFramework.Dal
{
    public class MealContext : DbContext
    {
        public MealContext() : base("MealContext")
        {
        }

        public DbSet<Meal> Meals { get; set; }
    }
}