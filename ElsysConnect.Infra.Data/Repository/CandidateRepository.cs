using Dapper;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Interfaces;
using Infra.Data.ContextDb;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

public class CandidateRepository : ICandidateRepository
{
    //private readonly Context _context;

    //public CandidateRepository(Context context)
    //{
    //    _context = context;
    //}

    //public Task DeleteAsync(Guid id)
    //{
    //    throw new NotImplementedException();
    //}

    //public async Task<IEnumerable<Candidate>> GetAllAsync()
    //{
    //    var connection = _context.Database.GetDbConnection();
    //    var query = "SELECT * FROM Candidates";
    //    var candidates = await connection.QueryAsync<Candidate>(query);
    //    return candidates;
    //}

    //public Task<Candidate> GetByIdAsync(Guid id)
    //{
    //    throw new NotImplementedException();
    //}

    //public Task InsertAsync(Candidate candidate)
    //{
    //    throw new NotImplementedException();
    //}

    //public Task UpdateAsync(Candidate candidate)
    //{
    //    throw new NotImplementedException();
    //}

    // Demais métodos da interface
}
