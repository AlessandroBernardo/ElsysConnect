using ElsysConnect.Application.Interfaces;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ElsysConnect.Application
{
    public class JobPositionAppService : BaseAppService<JobPosition>, IJobPositionAppService
    {
        //private readonly ICandidateRepository _candidateRepository;
        public JobPositionAppService(IJobPositionRepository jobPositionRepository) : base (jobPositionRepository)
        {
            //_candidateRepository = candidateRepository;
        }
    }
}
