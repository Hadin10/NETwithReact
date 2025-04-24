using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace withReact.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(ApplicationDbContext db, ILogger<DashboardController> logger)
        {
            _db = db;
            _logger = logger;
        }
        [HttpGet]
        [Route("getallpicturedata")]
        public async Task<IActionResult> GetAllPictureData()
        {
            var queryData = from p in _db.Product
                            select p.Name;
            var data = await queryData.ToListAsync();
            return new JsonResult(new { data = data, success = true });
        }
    }
}
