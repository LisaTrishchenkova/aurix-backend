using System.Reflection;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Aurix.Interfaces;
using Aurix.Interfaces.Enrollment;
using Aurix.Interfaces.Lesson;
using Aurix.Interfaces.Section;
using Aurix.Interfaces.Task;
using Aurix.Interfaces.User;
using Aurix.Models.Entities;
using Aurix.Repositories;
using Aurix.Services;
using Aurix.Services.Course;

namespace Aurix.Extensions;

public static class ServiceCollectionExtensions
{
	public static IServiceCollection AddApplicationServices(this IServiceCollection services)
	{
		services.AddScoped<ICourseRepository, CourseRepository>();
		services.AddScoped<ICourseService, CourseService>();
		services.AddScoped<ISectionRepository, SectionRepository>();
		services.AddScoped<ISectionService, SectionService>();
		services.AddScoped<ILessonRepository, LessonRepository>();
		services.AddScoped<ILessonService, LessonService>();
		services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
		services.AddScoped<IEnrollmentService, EnrollmentService>();
		services.AddScoped<ITaskRepository, TaskRepository>();
		services.AddScoped<IFavoriteRepository, FavoriteRepository>();
		services.AddScoped<IFavoriteService, FavoriteService>();
		services.AddScoped<IFileStorageService, LocalFileStorageService>();
		services.AddMediatR(cfg =>
			cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
		services.AddScoped<IJwtService, JwtService>();
		services.AddScoped<CourseSearchService>();
		services.AddScoped<ILessonProgressRepository, LessonProgressRepository>();

		return services;
	}

	public static IServiceCollection AddDatabase(
		this IServiceCollection services,
		IConfiguration configuration)
	{
		var connectionString = configuration.GetConnectionString("DefaultConnection")
							   ?? throw new InvalidOperationException(
								   "Connection string 'DefaultConnection' is not configured.");

		services.AddDbContext<ApplicationContext>(options =>
			options.UseNpgsql(
				connectionString,
				o => o.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName)));

		services.AddHostedService<MigrationHostedService>();

		return services;
	}

	public static IServiceCollection AddApiControllers(this IServiceCollection services)
	{
		services
			.AddControllers()
			.AddJsonOptions(options =>
			{
				options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
			});

		services.AddEndpointsApiExplorer();

		return services;
	}
}
