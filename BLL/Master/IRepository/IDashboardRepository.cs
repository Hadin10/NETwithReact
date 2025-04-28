using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Master.IRepository
{
    public interface IDashboardRepository
    {
        Task<IEnumerable<object>> GetDashboardAllPictureData();
    }
}
