using System.Collections;
using System.Collections.Generic;

namespace ElsysConnect.Domain.Entities
{
    public class RecruitmentPhase : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<JobPosition> JobPositions { get; set; }
    }
}
