using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using kiemtra_nqtk18b.Service;
using System;
using kiemtra_nqtk18b.Model;
using Microsoft.AspNetCore.Authorization;

namespace kiemtra_nqtk18b.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CategoryController : ControllerBase
    {
        public CategoryController() { }

        [HttpGet]
        public IActionResult GetAll()
        {
            var db = new Context();
            var service = new CategoryService(db);
            var categoryList = service.GetAll();
            return Ok(categoryList);
        }

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var db = new Context();
            var service = new CategoryService(db);
            var categoryList = service.GetAll();
            var category = categoryList.FirstOrDefault(e => e.Id == id);
            if (category != null)
            {
                return Ok(category);
            }
            return NotFound();
        }
    }

}
