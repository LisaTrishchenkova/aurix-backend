using Aurix.Models.DTOs;
using Aurix.Models.Requests;
using Aurix.Models.Responses;

namespace Aurix.Interfaces.Course;

public interface ICourseService
{
    Task<IReadOnlyCollection<CourseDto>> GetAllCoursesAsync();
    Task<CourseDto?> GetCourseByIdAsync(Guid id);
    Task<CourseDto> CreateCourseAsync(CreateCourseDto createCourseDto);
    Task<ServiceResult<CourseDto>> UpdateCourseAsync(Guid id, UpdateCourseDto updateCourseDto);
    Task<ServiceResult<IList<SectionDto>>> GetSectionsByCourseIdAsync(Guid courseId);
    Task<bool> DeleteCourseAsync(Guid id);
    Task<PaginatedResponse<CourseDto>> SearchAsync(CourseSearchRequest request);
    Task<ServiceResult<bool>> PublishCourseAsync(Guid id);

}