using System.Collections;
using Aurix.Models.Entities;

public interface ISectionRepository
{
    Task<IList<Section>?> GetAllAsync();
    Task<Section?> GetByIdAsync(Guid id);
    Task<Section> AddAsync(Section section);
    Task<Section> UpdateAsync(Section section);
    Task<bool> DeleteAsync(Section section);
    public Task<bool> CourseExistsAsync(Guid courseId);
}
