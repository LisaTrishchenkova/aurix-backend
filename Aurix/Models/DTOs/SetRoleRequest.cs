using System.ComponentModel.DataAnnotations;
using Aurix.Enums;

namespace Aurix.Models.DTOs;

public class SetRoleRequest
{
	[Required]
	[EnumDataType(typeof(UserRole))]
	public UserRole Role { get; set; }
}
