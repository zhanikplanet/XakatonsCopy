using Dataton_API.Context;
using Dataton_API.Modules.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Dataton_API.Controllers
{
    [Route("api/News")]
    [ApiController]
    public class NewsController:ControllerBase
    {
        private readonly DocumentsDbContext _db;
        public NewsController(DocumentsDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult<IEnumerable<News>> GetNews()
        {
            return Ok(_db.News.ToList());
        }
        [HttpGet("{id}", Name = "GetNewsById")]
        public ActionResult<News> GetNewsById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var news = _db.News.FirstOrDefault(x => x.Id == id);
            if (news == null)
            {
                return NotFound();
            }
            return Ok(news);
        }
    }
}
