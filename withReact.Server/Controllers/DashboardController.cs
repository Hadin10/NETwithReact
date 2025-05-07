using DAL.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using System.Reflection;
using BLL.UnitOfWork;

namespace withReact.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DashboardController> _logger;

        public DashboardController(IUnitOfWork unitOfWork, ILogger<DashboardController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }
        [HttpGet]
        [Route("getallpicturedata")]
        public async Task<IActionResult> GetAllPictureData()
        {
            //var data =await _unitOfWork.Dashboard.GetDashboardAllPictureData();
            var data =_unitOfWork.Dashboard.GetAllAsyncQueryable();
            var dashboardData = await data.Select(x=> new
            {
                x.Name,
                x.Title,
                x.Description,
            })
            .ToListAsync();
            return new JsonResult(new { data = dashboardData, success = true });
        }
    }
}
