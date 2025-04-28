using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Master.IRepository;

namespace BLL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IDashboardRepository Dashboard {get;}
    }
}
