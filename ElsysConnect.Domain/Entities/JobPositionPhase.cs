using System;
using System.Collections.Generic;
using System.Text;

namespace ElsysConnect.Domain.Entities
{
    public class JobPositionPhase : BaseEntity
    {
        public Guid JobPositionId { get; set; }
        public JobPosition JobPosition { get; set; }

        public Guid RecruitmentPhaseId { get; set; }
        public RecruitmentPhase RecruitmentPhase { get; set; }
    }
}
