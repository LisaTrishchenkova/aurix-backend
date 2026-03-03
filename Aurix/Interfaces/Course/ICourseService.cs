using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Aurix.Models.DTOs;
using Aurix;
using Aurix.Models.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

public interface ICourseService
{
    Task<IReadOnlyCollection<CourseDto>> GetAllCoursesAsync();
    Task<CourseDto?> GetCourseByIdAsync(Guid id);
    Task<CourseDto> CreateCourseAsync(CreateCourseDto createCourseDto);
    Task<CourseDto> UpdateCourseAsync(Guid id, UpdateCourseDto updateCourseDto);
    Task<ServiceResult<IList<SectionDto>>> GetSectionsByCourseIdAsync(Guid courseId);
    Task<bool> DeleteCourseAsync(Guid id);
    Task<PaginatedResponse<CourseDto>> SearchAsync(CourseSearchRequest request);
    Task<ServiceResult<bool>> PublishCourseAsync(Guid id);

}
