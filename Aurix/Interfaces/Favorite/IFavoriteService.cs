using Aurix.Models.DTOs;

namespace Aurix.Interfaces;

public interface IFavoriteService
{
	Task<ServiceResult<FavoriteDto>> AddFavoriteAsync(Guid courseId, Guid userId);
	Task<ServiceResult<bool>> RemoveFavoriteAsync(Guid courseId, Guid userId);
	Task<ServiceResult<IList<FavoriteDto>>> GetUserFavoritesAsync(Guid userId);
}
