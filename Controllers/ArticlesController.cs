using CsvHelper.Configuration;
using CsvHelper;
using Dataton_API.Context;
using Dataton_API.Modules.DTO_s;
using Dataton_API.Modules.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Dataton_API.Controllers
{
    [Route("api/Articles")]
    [ApiController]
    public class ArticlesController:ControllerBase
    {
        private readonly DocumentsDbContext _db;
        public ArticlesController(DocumentsDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Articles>> GetArticles()
        {
            return Ok(_db.Articles.ToList());
        }
        [HttpGet("{id}",Name ="GetArticlesById")]
        public ActionResult<Articles> GetArticlesById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var articles =_db.Articles.FirstOrDefault(x => x.Id == id);
            if(articles == null)
            {
                return NotFound();
            }
            return Ok(articles);
        }
        [HttpPost]
        public IActionResult ImportData(IFormFile file)
        {
            try
            {
                // Проверка, что файл был загружен
                if (file == null || file.Length == 0)
                {
                    return BadRequest("Файл не был загружен.");
                }

                // Чтение данных из файла
                using (var reader = new StreamReader(file.OpenReadStream()))
                using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    var records = csv.GetRecords<Articles>().ToList();

                    // Вставка данных в базу данных
                    _db.Articles.AddRange(records);
                    _db.SaveChanges();
                }

                return Ok("Данные успешно импортированы.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Произошла ошибка при импорте данных: " + ex.Message);
            }
        }

    }
}
