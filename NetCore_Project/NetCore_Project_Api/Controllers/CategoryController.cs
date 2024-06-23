using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCore_Project_Api.DAL.ApiContext;
using NetCore_Project_Api.DAL.Entity;

namespace NetCore_Project_Api.Controllers
{
    [Route("api/[controller]")]  //istek atarken önce api gelir sonra controllerName ==>  '/api/Category' 
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]  //verileri getirme
        public IActionResult CategoryList()
        {
            using var c = new Context();
            return Ok(c.Categories.ToList());  //Ok() api controllerlarında kullanılır 
        }


        [HttpGet("{id}")]  //id'ye göre veri getirme
        public IActionResult Get(int id)
        {
            using var c = new Context();
            var values = c.Categories.Find(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(values);
            }
        }


        [HttpPost]  // ekleme
        public IActionResult CategoryAdd(Category p)
        {
            using var c = new Context();
            c.Add(p);
            c.SaveChanges();
            return Created("", p);
        }


        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            using var c = new Context();
            var values = c.Categories.Find(id);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(values);
                c.SaveChanges();
                return Ok(values);
            }

        }


        [HttpPut]
        public IActionResult UpdateCategory(Category p)
        {
            using var c = new Context();
            var values = c.Find<Category>(p.CategoryId);
            if (values == null)
            {
                return NotFound();
            }
            else
            {
                values.CategoryName = p.CategoryName;
                c.Update(values);
                c.SaveChanges();
                return NoContent();
            }
        }
    }
}
