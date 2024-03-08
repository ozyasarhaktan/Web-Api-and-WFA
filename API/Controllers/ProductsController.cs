using API.Data;
using API.Models;
using API.Models.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly APIContext _context;
        private readonly IMapper _mapper;

        public ProductsController(APIContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/<Products>
        [HttpGet]
        public async Task<IEnumerable<Product>> GetAll()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }

        // GET api/<Products>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                BadRequest(product);
            }
            return product;
        }

        // POST api/<Products>
        [HttpPost]
        public async Task<IActionResult> Post(ProductDTO productDto)
        {
            Product addedProduct = _mapper.Map<Product>(productDto);

            await _context.AddAsync(addedProduct);
            var addedEntity = _context.Entry(addedProduct);
            addedEntity.State = EntityState.Added;
            await _context.SaveChangesAsync();
            return Ok(addedProduct);
        }

        // PUT api/<Products>/5
        [HttpPut]
        public async Task<IActionResult> Put(Product product)
        {
            //var prod = await _context.Products.FirstOrDefaultAsync(x => x.ProductID == productDTO.ProductID);



            //Product updatedProduct = _mapper.Map<Product>(productDTO);
            //updatedProduct.ProductID = productDTO.ProductID;
            //updatedProduct.ProductName = productDTO.ProductName;
            //updatedProduct.UnitPrice = productDTO.UnitPrice;
            //updatedProduct.UnitsInStock = productDTO.UnitsInStock;

            _context.Products.Update(product);
            await _context.SaveChangesAsync();

            return Ok(product);
        }

        // DELETE api/<Products>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if(product == null)
            {
                return NotFound(id);
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return Ok(product);
        }
    }
}
