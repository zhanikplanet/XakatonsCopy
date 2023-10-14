using Dataton_API.Context;
using Dataton_API.Modules.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Dataton_API.Controllers
{
    [Route("api/Service")]
    [ApiController]
    public class ServicesController:ControllerBase
    {
        private readonly DocumentsDbContext _db;
        public ServicesController(DocumentsDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Services>> GetServices()
        {
            return Ok(_db.Services.ToList());
        }
        [HttpGet("{id}", Name = "GetServicesById")]
        public ActionResult<Services> GetServicesById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var services = _db.Services.FirstOrDefault(x => x.Id == id);
            if (services == null)
            {
                return NotFound();
            }
            return Ok(services);
        }
    }
}
