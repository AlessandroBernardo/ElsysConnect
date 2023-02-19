using ElsysConnect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ElsysConnect.Application.Interfaces
{
    public interface IBaseAppService<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task InsertAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(Guid id);
    }
}
