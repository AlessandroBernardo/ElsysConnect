using System;
using System.Collections.Generic;
using System.Text;

namespace ElsysConnect.Domain.Entities
{
    public class CandidateRecruitmentPhase
    {
        public Guid Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public Guid CandidateId { get; set; }
        public Guid JobPositionRecruitmentPhaseId { get; set; }
        public Situation Situation { get; set; }
    }

    public enum Situation { 
    
        Aproved = 1,
        Reproved = 2,
        InProgress = 3    
    }

}
