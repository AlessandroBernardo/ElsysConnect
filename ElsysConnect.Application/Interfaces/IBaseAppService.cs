using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElsysConnect.Application.Interfaces
{
    public interface IBaseAppService<T>
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
