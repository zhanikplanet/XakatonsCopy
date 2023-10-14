using Dataton_API.Context;
using Dataton_API.Modules.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Dataton_API.Controllers
{
    [Route("api/LifeSituations")]
    [ApiController]
    public class LifeSituationsController:ControllerBase
    {
        private readonly DocumentsDbContext _db;
        public LifeSituationsController(DocumentsDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult<IEnumerable<LifeSituations>> GetLifeSituations()
        {
            return Ok(_db.LifeSituations.ToList());
        }
        [HttpGet("{id}", Name = "GetLifeSituationsById")]
        public ActionResult<LifeSituations> GetLifeSituationsById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var lifesituations = _db.LifeSituations.FirstOrDefault(x => x.Id == id);
            if (lifesituations == null)
            {
                return NotFound();
            }
            return Ok(lifesituations);
        }
    }
}
