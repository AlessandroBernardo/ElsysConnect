using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ElsysConnect.Domain.Entities
{
    public class JobPosition : BaseEntity
    {
        public string Title { get; set; }
        public DateTime? ClosingDate { get; set; }

        public virtual ICollection<Candidate> Candidates { get; set; }
        public virtual ICollection<RecruitmentPhase> RecruitmentPhases { get; set; }
    }
}
