using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;
using LazyVeganFridge.Models;
using LazyVeganFridge.ViewModels;

namespace LazyVeganFridge.Controllers
{
    [System.Web.Mvc.Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db = new ApplicationDbContext();

        //Shows categories and ingredients that belong to that category
        public async Task<ActionResult> Index()
        {
            var ingredients = db.FridgeIngredients.Include(a => a.Category).GroupBy(a => a.CategoryId).ToDictionary(x => x.Key, x => x.ToList());
            var categories = db.IngredientCategories.ToList();
            var homeviewmodel = new IngredientCreateEdit
            {
                FridgeIngredient = ingredients,
                Categories = categories
            };
            return View(homeviewmodel);
        }

        //Search function: checks what checkboxes are checked, compares those checked ingredients to the recipes and checks if there is a combination.
        public ActionResult search(FormCollection ingredients)
        {
            var ingredientIds = ingredients.AllKeys.Where(k => ingredients[k] == "on").ToList();

            var recipes = db.RecipeModels.Include(r => r.Ingredient).Where(r =>
                ingredientIds.All(I => r.Ingredient.Select(n => n.Id.ToString()).ToList().Contains(I))
            ).ToList();

            var test = new IngredientCreateEdit
            {
                Recipes = recipes
            };
            return View("Recipes", test);
        }
    }
}