using Aurix.Models.DTOs.Admin;
using Aurix.Models.DTOs.Moderation;

namespace Aurix.Interfaces.Moderation;

public interface IModerationService
{
	Task<ServiceResult<bool>> ClaimCourseAsync(Guid courseId, Guid moderatorId);
	Task<ServiceResult<bool>> ReleaseCourseAsync(Guid courseId, Guid moderatorId);
	Task<ServiceResult<CourseReviewDto>> GetCourseForReviewAsync(Guid courseId);
	Task<ModeratorStatsDto> GetMyStatsAsync(Guid moderatorId);
	System.Threading.Tasks.Task ReleaseStaleClaimsAsync(TimeSpan timeout);
}
