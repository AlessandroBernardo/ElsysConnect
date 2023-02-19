using Dapper;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Interfaces;
using Infra.Data.ContextDb;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElsysConnect.Infra.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly Context _context;
        protected readonly string _connectionString;

        public BaseRepository(Context context, string connectionString)
        {
            //ef
            _context = context;
            //puro
            _connectionString = connectionString;
        }  

        public async Task<IEnumerable<T>> GetAllAsync()
        {            
            //dapper
            IEnumerable<T> entities;
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();
                var tableName = typeof(T).Name + "s";
                var query = $"SELECT * FROM {tableName}";
                entities = await connection.QueryAsync<T>(query);
            }
            return entities;
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
