using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TModel>
        where TModel : class
    {
        Task AddAsync(TModel model);
        Task UpdateAsync(TModel model);
        Task DeleteAsync(TModel model);
        Task<TModel> GetByIdAsync(Guid id);
    }
}
