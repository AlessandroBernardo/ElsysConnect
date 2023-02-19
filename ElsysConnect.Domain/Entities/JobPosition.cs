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

        public ICollection<JobPositionPhase> JobPositionPhases { get; set; }
        public ICollection<JobPositionCandidate> JobPositionCandidates { get; set; }
    }
}
