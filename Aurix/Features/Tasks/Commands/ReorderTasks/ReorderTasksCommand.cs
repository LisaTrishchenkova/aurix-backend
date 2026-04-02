using MediatR;

namespace Aurix.Features.Tasks.Commands.ReorderTasks;

public class ReorderTasksCommand : IRequest
{
	public Guid LessonId { get; init; }
	public List<Guid> TaskIds { get; init; } = new();
}
