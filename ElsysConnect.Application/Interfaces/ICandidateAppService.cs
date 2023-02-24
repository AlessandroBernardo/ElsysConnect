using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElsysConnect.Application.Interfaces
{
    public interface ICandidateAppService : IBaseAppService<Candidate>
    {
        Task<IEnumerable<CandidateRecruitmentPhaseDto>> GetCandidatesRecruitmentPhases();
    }
}
