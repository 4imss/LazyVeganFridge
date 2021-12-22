using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using LazyVeganFridge.Controllers;
using LazyVeganFridge.Models;

namespace LazyVeganFridge.ViewModels
{
    public class IngredientCreateEdit
    {
        /// <summary>
        /// Gets or sets the fridgeingredient.
        /// </summary>
        [Required] public Dictionary<Guid, List<FridgeIngredient>> FridgeIngredient { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        [Required] public List<IngredientCategory> Categories { get; set; }

        /// <summary>
        /// Gets or sets the recipes.
        /// </summary>
        [Required] public List<RecipeModels> Recipes { get; set; }
    }
}