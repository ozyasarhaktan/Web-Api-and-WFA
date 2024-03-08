using API.Data;
using API.Models;
using API.Models.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly APIContext _context;
        private readonly IMapper _mapper;

        public CategoriesController(APIContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<Category>> GetAll()
        {
            List<Category> categories = await _context.Categories.ToListAsync();
            return categories;

        }

        [HttpGet]
        [Route("{id}")]
        public async Task<Category> Get(int id)
        {
            Category category = await _context.Categories.SingleOrDefaultAsync(x => x.CategoryID == id);

            if(category is null )
            {
                NotFound(category);
            }
            else if(!(_context.Categories.Any(x=> x.CategoryID == id)))
            {
                BadRequest(category);
            }
            return category;

        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryDto categoryDto)
        {
           Category addedCategory = _mapper.Map<Category>(categoryDto);

            var addedEntity = _context.Entry(addedCategory);
            addedEntity.State = EntityState.Added;

            await _context.AddAsync(addedCategory);     
            await _context.SaveChangesAsync();

            return Ok(addedCategory);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryDto categoryDto)
        {

        }
    }
}
