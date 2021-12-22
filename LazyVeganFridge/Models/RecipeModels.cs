using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LazyVeganFridge.Models
{
    //Recipe table
    public class RecipeModels
    {
        [Key] public Guid Id { get; set; }

        [Required, MinLength(4), MaxLength(50), DisplayName("Recept")]
        public string Name { get; set; }
        public string Description { get; set; }

        [DisplayName("Ingredients")]
        public List<FridgeIngredient> Ingredient { get; set; }
    }
}