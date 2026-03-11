using System.ComponentModel.DataAnnotations;
namespace Aurix.Models.DTOs
{
    public class CreateAuthorDto
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; } = null!;
    }
}
