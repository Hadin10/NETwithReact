using BLL.Master.Repository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Master.IRepository
{
    public interface IDashboardRepository:IMasterRepository<Product>
    {
        //Task<IEnumerable<object>> GetDashboardAllPictureData();
    }
}
