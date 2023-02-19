﻿using ElsysConnect.Application.Interfaces;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ElsysConnect.Web.Models.ElsysConnectModel

namespace ElsysConnect.Application
{
    public class BaseAppService<T> : IBaseAppService<T> where T : BaseViewModel
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

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
