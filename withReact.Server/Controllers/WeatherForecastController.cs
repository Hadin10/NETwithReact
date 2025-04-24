using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace withReact.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ApplicationDbContext db, ILogger<WeatherForecastController> logger)
        {
            _db = db;
            _logger = logger;
        }
        [HttpGet]
        [Route("getallpicturedata")]
        public async Task<IActionResult> GetAllPictureData()
        {
            //var data = await _db.Product.Where(x => x.Name == "Akram").Select(x => x.Id).ToListAsync();
            var queryData = from p in _db.Product
                            select p.Name;
            var data = await queryData.ToListAsync();
            return new JsonResult(new { data = data, success = true });
        }
        [HttpGet]
        [Route("getweatherforecast")]
        public async Task<IActionResult> Get()
        {
            //var data = await _db.Product.Where(x => x.Name == "Akram").Select(x => x.Id).ToListAsync();
            var queryData = from p in _db.Product
                            select p.Name;
            var data = await queryData.ToListAsync();
            return new JsonResult(new { data = data, success = true });
        }
    }
}
