using Dapper;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Interfaces;
using Infra.Data.ContextDb;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ElsysConnect.Infra.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly IDbConnection _dbConnection;

        public BaseRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            string sql = "SELECT * FROM " + typeof(T).Name + 's';
            var retorno = await _dbConnection.QueryAsync<T>(sql);
            return retorno;
        }       

        public async Task InsertAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }

}

