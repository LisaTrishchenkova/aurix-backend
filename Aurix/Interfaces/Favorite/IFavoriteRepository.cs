using Aurix.Models.Entities;

namespace Aurix.Interfaces;

public interface IFavoriteRepository
{
	Task<IList<Favorite>> GetByUserIdAsync(Guid userId);
	Task<Favorite?> GetByUserAndCourseAsync(Guid userId, Guid courseId);
	Task<Favorite> AddAsync(Favorite favorite);
	Task<bool> DeleteAsync(Favorite favorite);
}
