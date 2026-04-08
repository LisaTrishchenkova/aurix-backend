using MediatR;
using Aurix.Models.DTOs.Tasks;

namespace Aurix.Features.Tasks.Commands.CreateTextInputTask;

public class CreateTextInputTaskCommand : IRequest<TaskTeacherDto>
{
	public Guid LessonId { get; init; }
	public string Question { get; init; } = null!;
	public string CorrectAnswer { get; init; } = null!;
	public string? Explanation { get; init; }
	public List<string>? Hints { get; init; }
	public int Points { get; init; } = 1;
	public bool IsRequired { get; init; } = true;
}
