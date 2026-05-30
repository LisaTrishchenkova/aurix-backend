using MediatR;
using Aurix.Models.DTOs.Tasks;

namespace Aurix.Features.Tasks.Queries.GetMySubmission;

public class GetMySubmissionQuery : IRequest<TaskSubmissionDto?>
{
	public Guid TaskId { get; set; }
	public Guid UserId { get; set; }
}
