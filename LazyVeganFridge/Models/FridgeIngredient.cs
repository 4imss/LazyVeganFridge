using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LazyVeganFridge.Models
{
    // Ingredients table
    public class FridgeIngredient
    {
        [Key] public Guid Id { get; set; }

        [Required, MinLength(4), MaxLength(32), DisplayName("Ingredient")]
        public string Name { get; set; }

        [ForeignKey("Category")]
        public Guid CategoryId { get; set; }

        [DisplayName("Categorie")]
        public IngredientCategory Category { get; set; }

        public List<RecipeModels> RecipeModelsList { get; set; }
    }
}