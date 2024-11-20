using Core_App_Api.DAL.ApiContext;
using Core_App_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core_App_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public IActionResult CategoryList()
        {
            using var context = new Context();
            return Ok(context.Categories.ToList());
        }
        [HttpGet("{id}")]
        public IActionResult CategoryGetId(int id)
        {
            using var context = new Context();
            var value = context.Categories.Find(id);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(value);
            }
        }
        [HttpPost]
        public IActionResult CategoryAdd(Category category)
        {
            using var context = new Context();
            context.Add(category);
            context.SaveChanges();
            return Created("", category);
        }
        [HttpDelete]
        public IActionResult CategoryDelete(int id)
        {
            using var context = new Context();

            var value = context.Categories.Find(id);
            if (value == null)
            {
                return NotFound();

            }
            else
            {
                context.Remove(value);
                context.SaveChanges();
                return NoContent();
            }
        }
        [HttpPut]
        public IActionResult CategoryUpdate(Category category)
        {
            using var context = new Context();
            var value = context.Find<Category>(category.CategoryID);
            if (value == null)
            {
                return NotFound();
            }
            else
            {
                value.CategoryName = category.CategoryName;
                context.Update(value);
                context.SaveChanges();
                return NoContent();
            }
        }


    }
}
