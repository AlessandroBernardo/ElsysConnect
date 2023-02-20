using ElsysConnect.Application.Interfaces;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElsysConnect.Application
{
    public class CandidateAppService : BaseAppService<Candidate>, ICandidateAppService
    {
        //private readonly ICandidateRepository _candidateRepository;
        public CandidateAppService(ICandidateRepository candidateRepository) : base (candidateRepository)
        {
            //_candidateRepository = candidateRepository;
        }
    }
}
