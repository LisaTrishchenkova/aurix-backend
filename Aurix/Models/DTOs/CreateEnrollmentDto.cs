using System.ComponentModel.DataAnnotations;

namespace Aurix.Models.DTOs;

public class CreateEnrollmentDto
{
	[Required]
	public Guid CourseId { get; set; }

}
