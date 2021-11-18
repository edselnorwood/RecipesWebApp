using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace RecipesWebApp.Models
{
    public class Recipes
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Ingredients { get; set; }

        public string? Instructions { get; set; }
        public string? CookTime { get; set; }

        [NotMapped]

        [Display(Name = "Image")]

        [DataType(DataType.Upload)]

        public IFormFile? ImageFile { get; set; }

        public byte[]? ImageData { get; set; }

        public string? ImageType { get; set; }
    }
}