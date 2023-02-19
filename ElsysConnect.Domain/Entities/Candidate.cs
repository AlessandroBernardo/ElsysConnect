using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ElsysConnect.Domain.Entities
{
    public class Candidate : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }

        public virtual ICollection<JobPosition> JobPositions { get; set; }
        public virtual ICollection<RecruitmentPhase> RecruitmentPhases { get; set; }
    }
}
