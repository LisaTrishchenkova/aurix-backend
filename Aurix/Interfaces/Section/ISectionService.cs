using System.Collections;
using Aurix.Models.DTOs;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aurix.Interfaces.Section
{
    public interface ISectionService
    {
        Task<IReadOnlyCollection<SectionDto>> GetAllSectionsAsync();
        Task<SectionDto?> GetSectionByIdAsync(Guid id);
        Task<SectionDto> CreateSectionAsync(Guid courseId, CreateSectionDto createSectionDto);
        Task<SectionDto> UpdateSectionAsync(Guid id, UpdateSectionDto updateSectionDto);
        Task<bool> DeleteSectionsAsync(Guid id);
        Task<IList<SectionDto>> GetSectionsByCourseIdAsync(Guid courseId);
    }
}
