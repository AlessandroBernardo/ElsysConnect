using System;
using System.Collections.Generic;
using System.Text;

namespace ElsysConnect.Domain.Entities
{
    public class CandidatePhase
    {
        public Guid CandidateId { get; set; }
        public Guid RecruitmentPhaseId { get; set; }
        public CandidateStatus Status { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual RecruitmentPhase RecruitmentPhase { get; set; }
    }

    public enum CandidateStatus
    {
        Pending,
        Approved,
        Rejected
    }
}
