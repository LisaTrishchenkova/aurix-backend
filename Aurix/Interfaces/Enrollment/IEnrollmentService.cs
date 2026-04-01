using Aurix.Models.DTOs;

namespace Aurix.Interfaces.Enrollment;

public interface IEnrollmentService
{
	Task<ServiceResult<EnrollmentDto>> EnrollAsync(Guid courseId, Guid userId);
	Task<ServiceResult<bool>> CancelEnrollmentAsync(Guid enrollmentId, Guid userId);
	Task<ServiceResult<IList<EnrollmentDto>>> GetUserEnrollmentsAsync(Guid userId);
}
