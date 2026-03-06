using System.ComponentModel.DataAnnotations;
namespace Aurix.Models.DTOs
{
    public class CreateCategoryDto
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; } = null!;
    }
}
