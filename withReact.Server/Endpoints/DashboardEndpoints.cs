using BLL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using withReact.Server.Controllers;

namespace withReact.Server.Endpoints
{
    public static class DashboardEndpoints
    {
        public static void MapDashboardEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/dashboard");
            //Get All Picture
            group.MapGet("/getallpicturedata", async (IUnitOfWork unitOfWork) =>
            {
                var data = unitOfWork.Dashboard.GetAllAsyncQueryable();
                var dashboardData = await data.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Title,
                    x.Description
                }).ToListAsync();
                return Results.Json(new { data = dashboardData, success = true });
            });
            //Get Picture Detailes
            group.MapGet("/getpicturedetailesdata", async (IUnitOfWork unitOfWork, long id) =>
            {
                var data = await unitOfWork.Dashboard.GetAsync(id);
                return Results.Json(new { data = data, success = true });
            });
        }
    }
}
