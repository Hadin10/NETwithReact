using DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using BLL.Master.IRepository;
using System.Reflection.Metadata;
using DAL.Models;

namespace BLL.Master.Repository
{
    public class DashboardRepository: MasterRepository<Product>,IDashboardRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly ILogger<DashboardRepository> _logger;

        public DashboardRepository(ApplicationDbContext db, ILogger<DashboardRepository> logger) : base(db)
        {
            _db = db;
            _logger = logger;
        }
        //public async Task<IEnumerable<object>> GetDashboardAllPictureData()
        //{
        //    var queryData = from p in _db.Product
        //                    select new
        //                    {
        //                        p.Name,
        //                        p.Title,
        //                        p.Description,
        //                    };
        //    var data = await queryData.ToListAsync();
        //    return data;
        //}
    }
}
