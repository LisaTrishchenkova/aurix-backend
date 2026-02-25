using Aurix.Models.DTOs;

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
