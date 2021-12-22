using System.Collections.Generic;
using LazyVeganFridge.Models;

namespace LazyVeganFridge.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LazyVeganFridge.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LazyVeganFridge.Models.ApplicationDbContext context)
        {
            //base.Seed(context);
            //This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            ////  to avoid creating duplicate seed data.
            //context.IngredientCategories.AddOrUpdate(x => x.Name,
            //    new IngredientCategory() { Id = Guid.Parse("{08bfff62-a318-48b7-8744-08ee17212383}"), Name = "Fruits" },
            //    new IngredientCategory() { Id = Guid.Parse("{f2e72dd0-9f63-4bc7-bbce-4dd2a56aaadc}"), Name = "Dairy substitutes" },
            //    new IngredientCategory() { Id = Guid.Parse("{3e2f4afd-8e7d-4143-8b2c-fe94f0de5671}"), Name = "Grains" },
            //    new IngredientCategory() { Id = Guid.Parse("{78507d9a-f395-4585-9542-79b8ca3a9613}"), Name = "Legumes" },
            //    new IngredientCategory() { Id = Guid.Parse("{aaf88a9e-e319-495e-807c-d1606829e3b1}"), Name = "Meat substitutes" },
            //    new IngredientCategory() { Id = Guid.Parse("{7072788e-6eed-4bb7-9862-8734a6b64106}"), Name = "Spices / Seasonings" },
            //    new IngredientCategory() { Id = Guid.Parse("{c4e72dd0-9f63-4bc7-bbce-4dd2a56aaadc}"), Name = "Vegetables" }

            //);

            //// creating ingredients var and connecting them to Categories
            //var avocado = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Avocado", CategoryId = Guid.Parse("{08bfff62-a318-48b7-8744-08ee17212383}"), RecipeModelsList = new List<RecipeModels>() };
            //var parmesan = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Vegan parmesan", CategoryId = Guid.Parse("{f2e72dd0-9f63-4bc7-bbce-4dd2a56aaadc}"), RecipeModelsList = new List<RecipeModels>() };
            //var rice = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Brown rice", CategoryId = Guid.Parse("{3e2f4afd-8e7d-4143-8b2c-fe94f0de5671}"), RecipeModelsList = new List<RecipeModels>() };
            //var tortillas = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Corn tortillas", CategoryId = Guid.Parse("{3e2f4afd-8e7d-4143-8b2c-fe94f0de5671}"), RecipeModelsList = new List<RecipeModels>() };
            //var chickpeapasta = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Chickpea pasta", CategoryId = Guid.Parse("{3e2f4afd-8e7d-4143-8b2c-fe94f0de5671}"), RecipeModelsList = new List<RecipeModels>() };
            //var wheatpasta = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Wheat pasta", CategoryId = Guid.Parse("{3e2f4afd-8e7d-4143-8b2c-fe94f0de5671}"), RecipeModelsList = new List<RecipeModels>() };
            //var corn = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Corn", CategoryId = Guid.Parse("{78507d9a-f395-4585-9542-79b8ca3a9613}"), RecipeModelsList = new List<RecipeModels>() };
            //var blackbeans = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Black beans", CategoryId = Guid.Parse("{78507d9a-f395-4585-9542-79b8ca3a9613}"), RecipeModelsList = new List<RecipeModels>() };
            //var tofu = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Tofu", CategoryId = Guid.Parse("{aaf88a9e-e319-495e-807c-d1606829e3b1}"), RecipeModelsList = new List<RecipeModels>() };
            //var stock = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Vegetable stock", CategoryId = Guid.Parse("{7072788e-6eed-4bb7-9862-8734a6b64106}"), RecipeModelsList = new List<RecipeModels>() };
            //var salt = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Salt", CategoryId = Guid.Parse("{7072788e-6eed-4bb7-9862-8734a6b64106}"), RecipeModelsList = new List<RecipeModels>() };
            //var pepper = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Pepper", CategoryId = Guid.Parse("{7072788e-6eed-4bb7-9862-8734a6b64106}"), RecipeModelsList = new List<RecipeModels>() };
            //var chilipowder = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Chili powder", CategoryId = Guid.Parse("{7072788e-6eed-4bb7-9862-8734a6b64106}"), RecipeModelsList = new List<RecipeModels>() };
            //var pepperflakes = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Red pepper flakes", CategoryId = Guid.Parse("{7072788e-6eed-4bb7-9862-8734a6b64106}"), RecipeModelsList = new List<RecipeModels>() };
            //var soysauce = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Soy sauce", CategoryId = Guid.Parse("{7072788e-6eed-4bb7-9862-8734a6b64106}"), RecipeModelsList = new List<RecipeModels>() };
            //var parsley = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Parsley", CategoryId = Guid.Parse("{7072788e-6eed-4bb7-9862-8734a6b64106}"), RecipeModelsList = new List<RecipeModels>() };
            //var marinara = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Marinara sauce", CategoryId = Guid.Parse("{7072788e-6eed-4bb7-9862-8734a6b64106}"), RecipeModelsList = new List<RecipeModels>() };
            //var tomatoes = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Roasted tomatoes", CategoryId = Guid.Parse("{c4e72dd0-9f63-4bc7-bbce-4dd2a56aaadc}"), RecipeModelsList = new List<RecipeModels>() };
            //var yellowonion = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Yellow onion", CategoryId = Guid.Parse("{c4e72dd0-9f63-4bc7-bbce-4dd2a56aaadc}"), RecipeModelsList = new List<RecipeModels>() };
            //var greenpepper = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Green pepper", CategoryId = Guid.Parse("{c4e72dd0-9f63-4bc7-bbce-4dd2a56aaadc}"), RecipeModelsList = new List<RecipeModels>() };
            //var lettuce = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Lettuce", CategoryId = Guid.Parse("{c4e72dd0-9f63-4bc7-bbce-4dd2a56aaadc}"), RecipeModelsList = new List<RecipeModels>() };
            //var vegetables = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Mixed vegetables", CategoryId = Guid.Parse("{c4e72dd0-9f63-4bc7-bbce-4dd2a56aaadc}"), RecipeModelsList = new List<RecipeModels>() };
            //var spinach = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Spinach", CategoryId = Guid.Parse("{c4e72dd0-9f63-4bc7-bbce-4dd2a56aaadc}"), RecipeModelsList = new List<RecipeModels>() };
            //var redonion = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Red onion", CategoryId = Guid.Parse("{c4e72dd0-9f63-4bc7-bbce-4dd2a56aaadc}"), RecipeModelsList = new List<RecipeModels>() };
            //var garlic = new FridgeIngredient() { Id = Guid.NewGuid(), Name = "Garlic", CategoryId = Guid.Parse("{c4e72dd0-9f63-4bc7-bbce-4dd2a56aaadc}"), RecipeModelsList = new List<RecipeModels>() };

            ////creating all the recipes
            //var recipe1 = new RecipeModels()
            //{
            //    Id = Guid.Parse("{b0d04c4a-deae-4c02-ad7e-b44daa36e626}"),
            //    Name = "Garlic whole wheat pasta",
            //    Description = @"Step 1: Prepare 8 oz whole wheat pasta according to package directions.

            //                Step 2: Add 1/2 vegetable stock to a large sauté pan on medium-high heat. Add 5 cloves minced garlic and 1/2 tsp crushed red pepper flakes. Cook until garlic softens and becomes fragrant about 8 minutes. Stir frequently so that garlic won’t burn.

            //                Step 3: Add pasta and 1/4 cup of reserved pasta water to the sauté pan. Toss together until combined. Add parsley and salt and pepper to taste. If pasta seems too dry add a little more pasta water. Sprinkle with red pepper flakes and optional vegan parmesan cheese."
            //};
            //var recipe2 = new RecipeModels()
            //{
            //    Id = Guid.Parse("{30a7b8d2-82a6-4063-bdec-4643d3f540ab}"),
            //    Name = "Chickpea pasta with marinara and spinach",
            //    Description = @"Step 1: Prepare 8 oz of chickpea pasta according to package instructions.

            //Step 2: Heat 2 cups of pre-made marinara sauce on a large sauce pan over medium heat. Add 12 oz spinach when sauce begins to boil. Reduce heat and cover. Cook for an additional 5 minutes or until spinach wilts.

            //Step 3: Combine cooked and drained pasta with sauce. Sprinkle with vegan parmesan cheese (optional)."
            //};
            //var recipe3 = new RecipeModels()
            //{
            //    Id = Guid.Parse("{48915661-9851-47c3-ba7b-6c30dec286b4}"),
            //    Name = "Vegan fried rice with tofu",
            //    Description = @"Step 1: Cook 1 package of brown rice in the microwave according to package directions. If you don’t have a brown rice steamer bag, you can make instant pot brown rice to save time.

            //Step 2: While rice is cooking, press water out of 16 oz extra firm tofu for about 15 minutes. Drain water from tofu. Place tofu block on two paper towels folded into quarters, fold two additional paper towels into quarters, and place on the top of the tofu. Gently but firmly press on the top of the tofu for 1-2 minutes. Then dice tofu into cubes.

            //Step 3: Heat 1/4 cup of soy sauce in a large skillet. Add 1 small red diced onion. Cook for 3-5 minutes or until translucent. Add tofu. Cook until tofu begins to brown, about 5-10 minutes.
            //Step 4: Add 2 cups of frozen mixed vegetables to your liking, carrots, peas, corn, and green beans are commonly used. Cook brown rice. Cover and cook for an additional 5 minutes, or until frozen vegetables are cooked through."
            //};
            //var recipe4 = new RecipeModels()
            //{
            //    Id = Guid.Parse("{201ef7de-7bff-48d1-9ef2-1c8b56b22f1e}"),
            //    Name = "Black bean tacos",
            //    Description = @"Step 1: Drain and rinse 15 oz black beans.

            //Step 2: Add to medium saucepan. Add 2tsp taco seasoning (optional), and 1/2 cup frozen corn. Stir to combine. Cover and cook for 5 minutes or until corn is warm and cooked through. While beans are simmering, warm 4-8 corn tortillas in microwave for 10-20 seconds each.

            //Step 3: Assemble tacos. Add black beans to corn tortillas. Top with lettuce, salsa, and diced avocado (optional)."
            //};
            //var recipe5 = new RecipeModels()
            //{
            //    Id = Guid.Parse("{52bcb721-d5c6-42c0-b3e1-0a17752034ac}"),
            //    Name = "Vegan bean chili",
            //    Description = @"Step 1: Sauté onions in 1/4 cup of vegetable stock. Cook until translucent. Add 1 chopped green pepper and 1 tbsp chili powder. Cook an additional 2-3 minutes.

            //Step 2: Add 1 cup vegetable stock, 14 oz fire roasted tomatoes, and 14 oz black beans. Simmer on low for 20 minutes. Add salt and pepper to taste."
            //};

            //binding ingredients to recipes
            //parmesan.RecipeModelsList.Add(recipe1);
            //parmesan.RecipeModelsList.Add(recipe2);
            //avocado.RecipeModelsList.Add(recipe1);
            //avocado.RecipeModelsList.Add(recipe4);
            //rice.RecipeModelsList.Add(recipe3);
            //tortillas.RecipeModelsList.Add(recipe4);
            //wheatpasta.RecipeModelsList.Add(recipe1);
            //chickpeapasta.RecipeModelsList.Add(recipe2);
            //corn.RecipeModelsList.Add(recipe4);
            //blackbeans.RecipeModelsList.Add(recipe4);
            //blackbeans.RecipeModelsList.Add(recipe5);
            //tofu.RecipeModelsList.Add(recipe3);
            //stock.RecipeModelsList.Add(recipe1);
            //stock.RecipeModelsList.Add(recipe5);
            //salt.RecipeModelsList.Add(recipe1);
            //salt.RecipeModelsList.Add(recipe5);
            //pepper.RecipeModelsList.Add(recipe1);
            //pepper.RecipeModelsList.Add(recipe5);
            //chilipowder.RecipeModelsList.Add(recipe5);
            //pepperflakes.RecipeModelsList.Add(recipe1);
            //soysauce.RecipeModelsList.Add(recipe3);
            //parsley.RecipeModelsList.Add(recipe1);
            //marinara.RecipeModelsList.Add(recipe2);
            //tomatoes.RecipeModelsList.Add(recipe5);
            //yellowonion.RecipeModelsList.Add(recipe5);
            //greenpepper.RecipeModelsList.Add(recipe5);
            //lettuce.RecipeModelsList.Add(recipe4);
            //vegetables.RecipeModelsList.Add(recipe3);
            //spinach.RecipeModelsList.Add(recipe2);
            //redonion.RecipeModelsList.Add(recipe3);
            //garlic.RecipeModelsList.Add(recipe1);

            //// adding the var ingredients to the database
            //context.FridgeIngredients.AddOrUpdate(avocado);
            //context.FridgeIngredients.AddOrUpdate(parmesan);
            //context.FridgeIngredients.AddOrUpdate(rice);
            //context.FridgeIngredients.AddOrUpdate(tortillas);
            //context.FridgeIngredients.AddOrUpdate(chickpeapasta);
            //context.FridgeIngredients.AddOrUpdate(wheatpasta);
            //context.FridgeIngredients.AddOrUpdate(corn);
            //context.FridgeIngredients.AddOrUpdate(blackbeans);
            //context.FridgeIngredients.AddOrUpdate(tofu);
            //context.FridgeIngredients.AddOrUpdate(stock);
            //context.FridgeIngredients.AddOrUpdate(salt);
            //context.FridgeIngredients.AddOrUpdate(pepper);
            //context.FridgeIngredients.AddOrUpdate(chilipowder);
            //context.FridgeIngredients.AddOrUpdate(pepperflakes);
            //context.FridgeIngredients.AddOrUpdate(soysauce);
            //context.FridgeIngredients.AddOrUpdate(parsley);
            //context.FridgeIngredients.AddOrUpdate(marinara);
            //context.FridgeIngredients.AddOrUpdate(tomatoes);
            //context.FridgeIngredients.AddOrUpdate(yellowonion);
            //context.FridgeIngredients.AddOrUpdate(greenpepper);
            //context.FridgeIngredients.AddOrUpdate(lettuce);
            //context.FridgeIngredients.AddOrUpdate(vegetables);
            //context.FridgeIngredients.AddOrUpdate(spinach);
            //context.FridgeIngredients.AddOrUpdate(redonion);
            //context.FridgeIngredients.AddOrUpdate(garlic);

            //context.SaveChanges();
        }
    }
}
