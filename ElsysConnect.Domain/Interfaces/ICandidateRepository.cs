using ElsysConnect.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElsysConnect.Domain.Interfaces
{
    public interface ICandidateRepository : IBaseRepository<Candidate>
    {
        //Task<IEnumerable<Candidate>> GetAllAsync();
        //Task<Candidate> GetByIdAsync(Guid id);
        //Task InsertAsync(Candidate candidate);
        //Task UpdateAsync(Candidate candidate);
        //Task DeleteAsync(Guid id);
    }
}
