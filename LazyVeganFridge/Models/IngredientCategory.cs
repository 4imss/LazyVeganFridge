using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LazyVeganFridge.Models
{
    //Category table
    public class IngredientCategory
    {
        [Key] public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [Required]
        [MinLength(4)]
        [Display(Name = "Test")]
        [MaxLength(32)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

    }
}