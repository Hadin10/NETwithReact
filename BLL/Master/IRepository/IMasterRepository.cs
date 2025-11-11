using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Master.Repository
{
    public interface IMasterRepository<T> where T : class
    {
        IQueryable<T> GetAllAsyncQueryable(Expression<Func<T, bool>>? filter = null, string? includeProperties = null);
        Task<T> GetAsync(long id);
    }
}
