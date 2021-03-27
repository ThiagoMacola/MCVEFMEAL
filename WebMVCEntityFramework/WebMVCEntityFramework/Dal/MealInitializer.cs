using System.Collections.Generic;
using System.Data.Entity;
using WebMVCEntityFramework.Models;

namespace WebMVCEntityFramework.Dal
{
    public class MealInitializer : DropCreateDatabaseIfModelChanges<MealContext>
    {
        protected override void Seed(MealContext context)
        {
            var meals = new List<Meal>
            {
                new Meal
                {
                    Id = 1,
                    Description = "Hamburguer",
                    Value = 29.90m
                },
                new Meal
                {
                    Id = 2,
                    Description = "Hotdog",
                    Value = 14.90m
                },
                new Meal
                {
                    Id = 3,
                    Description = "Pizza frango c/ barbecue",
                    Value = 49.90m
                }
            };
            meals.ForEach(m => context.Meals.Add(m));
            context.SaveChanges();
        }
    }
}