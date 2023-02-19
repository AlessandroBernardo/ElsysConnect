using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ElsysConnect.Domain.Entities
{
    public class Candidate : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }

        public ICollection<CandidatePhase> CandidatePhases { get; set; }
        public ICollection<JobPositionCandidate> JobPositionCandidates { get; set; }
    }
}
}
