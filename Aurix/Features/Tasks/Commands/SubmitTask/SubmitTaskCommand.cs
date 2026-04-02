using MediatR;
using Aurix.Models.DTOs.Tasks;

namespace Aurix.Features.Tasks.Commands.SubmitTask;

public class SubmitTaskCommand : IRequest<TaskSubmissionDto>
{
	public Guid TaskId { get; init; }
	public Guid UserId { get; init; }
	public int? AnswerIndex { get; init; }
	public List<int>? AnswerIndexes { get; init; }
	public string? AnswerText { get; init; }
}
