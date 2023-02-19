using System;
using System.Collections.Generic;
using System.Text;

namespace ElsysConnect.Domain.Entities
{
    public class JobPositionRecruitmentPhase
    {
        public Guid Id { get; set; }
        public DateTime InsertDate { get; set; }
        public Guid JobPositionId { get; set; }
        public Guid RecruitmentPhaseId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
