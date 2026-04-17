using System.ComponentModel.DataAnnotations;

namespace Aurix.Models.Requests.UserRequest;

public class ChangePasswordRequest
{
	[Required]
	public string OldPassword { get; set; } = null!;

	[Required]
	[MinLength(8)]
	public string NewPassword { get; set; } = null!;
}
