using Microsoft.EntityFrameworkCore;
using RecipesWebApp.Data;

namespace RecipesWebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RecipesWebAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RecipesWebAppContext>>()))
            {
                // Look for any movies.
                if (context.Recipes.Any())
                {
                    return;   // DB has been seeded
                }

                var newline = System.Environment.NewLine;

                context.Recipes.AddRange(
                    new Recipes
                    {
                        Title = "SHEET PAN HARISSA CHICKEN BREASTS WITH CAULIFLOWER AND SWEET POTATOES",
                        Ingredients =
                        "INGREDIENTS" + newline +
                        "2 large split chicken breasts with bone and skin(about 1 pound total)" + newline +
                        "1 large head cauliflower, cored and cut in florets" + newline +
                        "2 medium sweet potatoes washed and cut in 1 - inch pieces" + newline +
                        "¼ cup mild harissa sauce" + newline +
                        "3 tablespoons olive oil, Salt, and pepper to taste",
                        Instructions =
                        "INSTRUCTIONS" + newline +
                        "1.Heat oven to 400 degrees." + newline +
                        "2.In a large bowl combine all ingredients.Toss together to coat chicken and vegetables evenly with harissa and oil.Season with salt and pepper." + newline +
                        "3.Place chicken breasts skin side - up in the middle of a sheet pan.Spread cauliflower and sweet potatoes in an even layer in the remaining space on the sheet pan." + newline +
                        "4.Bake 40 minutes in the preheated oven.If chicken is not opaque and cooked throughout cook for an additional 5 minutes." + newline +
                        "5.Cool slightly before serving.",
                        CookTime = "50 Mins"
                    },

                    new Recipes
                    {
                        Title = "SPICY QUICK FIX CHILI",
                        Instructions =
                        "INSTRUCTIONS" + newline +
                        "1   Brown ground beef in large skillet on medium - high heat; drain if needed." + newline +
                        "2   Stir in remaining ingredients; bring to boil.Reduce heat to low; simmer 10 minutes.",
                        Ingredients =
                        "INGREDIENTS 5 Servings" + newline +
                        "1 pound ground beef" + newline +
                        "2 cans(14 1 / 2 ounces each) stewed tomatoes" + newline +
                        "1 can(15 ounces) kidney beans drained and rinsed" + newline +
                        "2 tablespoons McCormick® Chili Powder" + newline +
                        "1 teaspoon McCormick® Ground Cumin",
                        CookTime = "15 Mins"
                    },
                    new Recipes
                    {
                        Title = "TORTILLA CHICKEN CHILI",
                        Ingredients =
                        "INGREDIENTS" + newline +
                        " 6 (1 Cup) Servings" + newline +
                        "1 tablespoon oil" + newline +
                        "1 pound boneless skinless chicken breast halves cut into 3 / 4 - inch cubes" + newline +
                        "1 package McCormick® Chili Seasoning Mix" + newline +
                        "1 can(14 1 / 2 ounces) diced tomatoes undrained" + newline +
                        "1 can(15 to 16 ounces) kidney beans undrained substitution Substitutions available" + newline +
                        "1 can(11 ounces) Mexican - style corn drained substitution Substitutions available" + newline +
                        "1 / 2 cup water" + newline +
                        "1 1 / 2 cups bite - size tortilla chips",
                        Instructions =
                        "INSTRUCTIONS" + newline +
                        "1 Heat oil in large nonstick skillet on medium-high heat. Add chicken; cook and stir 5 minutes or until lightly browned." + newline +
                        "2   Stir in Seasoning Mix, tomatoes, beans, corn, water and tortilla chips.Bring to boil.Reduce heat to low; cover and simmer 10 minutes, stirring occasionally." + newline +
                        "3 Serve with desired toppings.",
                        CookTime = "16 Mins"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}