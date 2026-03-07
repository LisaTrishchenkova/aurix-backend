using Aurix.Models.Entities;
using Aurix.Models.DTOs;
using Aurix.Enums;
public class CourseDto
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public CourseStatus Status { get; set; }
    public Guid? CategoryId { get; set; }
    public ICollection<TagDto>? Tags { get; set; } = new List<TagDto>();
}
