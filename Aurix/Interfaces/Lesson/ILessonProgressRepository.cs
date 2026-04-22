using Aurix.Models.Entities;

namespace Aurix.Interfaces.Lesson;

public interface ILessonProgressRepository
{
    Task<LessonProgress?> GetAsync(Guid userId, Guid lessonId);
    Task<LessonProgress> AddAsync(LessonProgress progress);
    Task<int> CountCompletedAsync(Guid enrollmentId);
    Task<int> CountTotalLessonsInCourseAsync(Guid courseId);
}
