using System;
using System.Collections.Generic;
using System.Text;

namespace ElsysConnect.Domain.Entities.Dtos
{
    public class CandidateRecruitmentPhaseDto
    {
        public Guid Id { get; set; }
        
        public string CandidateName { get; set; }
        public string CandidateEmail { get; set; }
        public string CandidatePhone { get; set; }
        public string JobPositionTitle { get; set; }
        public List<PhasesDto> PhasesDTOs { get; set; }
    }

    public class PhasesDto {
        public string PhaseName { get; set; }
        public int Status { get; set; }

    }
}
