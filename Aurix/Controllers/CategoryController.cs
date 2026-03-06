using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Aurix.Models.DTOs;
using Aurix.Models.Entities;
namespace Aurix.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public CategoryController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetAllCategories()
        {
            var categories = await _context.Categories
                .Select(c => new CategoryDto
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();

            return Ok(categories);
        }
    }
}
