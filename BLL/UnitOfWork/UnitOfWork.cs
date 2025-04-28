using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Master.IRepository;
using BLL.Master.Repository;
using DAL.Data;
using Microsoft.Extensions.Logging;
namespace BLL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly ApplicationDbContext _db;
        public readonly ILogger<DashboardRepository> _logger;
        public UnitOfWork(ApplicationDbContext db, ILogger<DashboardRepository> logger)
        {
            _db = db;
            _logger = logger;
            Dashboard = new DashboardRepository(db, logger);
        }
        public IDashboardRepository Dashboard { get; }

        public async void Dispose()
        {
            await _db.DisposeAsync();
        }
    }
}
