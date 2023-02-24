using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElsysConnect.Domain.Interfaces
{
    public interface ICandidateRepository : IBaseRepository<Candidate>
    {
        Task<IEnumerable<CandidateRecruitmentPhaseDto>> GetCandidatesRecruitmentPhases();
    }
}
