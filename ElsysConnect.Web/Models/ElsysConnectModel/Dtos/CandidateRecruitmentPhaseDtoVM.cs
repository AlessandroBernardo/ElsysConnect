using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElsysConnect.Web.Models.ElsysConnectModel.Dtos
{
    public class CandidateRecruitmentPhaseDtoVM
    {
        public Guid Id { get; set; }

        public string CandidateName { get; set; }
        public string CandidateEmail { get; set; }
        public string CandidatePhone { get; set; }
        public string JobPositionTitle { get; set; }
        public List<PhasesDtoVM> PhasesDTOs { get; set; }
    }

    public class PhasesDtoVM
    {
        public string PhaseName { get; set; }
        public int Status { get; set; }

    }


}
