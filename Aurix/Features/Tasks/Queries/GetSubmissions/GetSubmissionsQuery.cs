using MediatR;
using Aurix.Models.DTOs.Tasks;

namespace Aurix.Features.Tasks.Queries.GetSubmissions;

public class GetSubmissionsQuery : IRequest<IList<TaskSubmissionDto>>
{
	public Guid TaskId { get; init; }
}
