using ElsysConnect.Application.Interfaces;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace ElsysConnect.Application
{
    public class BaseAppService<T> : IBaseAppService<T> where T : class
    {

        private readonly IBaseRepository<T> _baseRepository;

        public BaseAppService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }     

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            try
            {
                IEnumerable<T> list = await _baseRepository.GetAllAsync();
                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }            
            
        }

        #region MyRegion
        public async Task<T> GetByIdAsync(Guid id)
        {
            var entity = await _baseRepository.GetByIdAsync(id);
            return entity;
        }

        public Task InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            await _baseRepository.DeleteAsync(id);
        }
        #endregion
    }
}
