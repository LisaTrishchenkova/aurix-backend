using System.Collections;
using Aurix.Models.DTOs;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Aurix.Interfaces.Section
{
    public interface ISectionService
    {
        Task<ServiceResult<IReadOnlyCollection<SectionDto>>> GetAllSectionsAsync();
        Task<ServiceResult<SectionDto?>> GetSectionByIdAsync(Guid id);
        Task<ServiceResult<SectionDto>> CreateSectionAsync(Guid courseId, CreateSectionDto createSectionDto);
        Task<ServiceResult<SectionDto>> UpdateSectionAsync(Guid id, UpdateSectionDto updateSectionDto);
        Task<ServiceResult<bool>> DeleteSectionAsync(Guid id);
    }
}
