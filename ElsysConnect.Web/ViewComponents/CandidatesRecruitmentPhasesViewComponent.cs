using AutoMapper;
using ElsysConnect.Application.Interfaces;
using ElsysConnect.Domain.Entities.Dtos;
using ElsysConnect.Web.Models.ElsysConnectModel.Dtos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElsysConnect.Web.ViewComponents
{
    public class CandidatesRecruitmentPhasesViewComponent : ViewComponent
    {

        private readonly ICandidateAppService _candidateAppService;
        private readonly IMapper _mapper;

        public CandidatesRecruitmentPhasesViewComponent(ICandidateAppService candidateAppService, IMapper mapper)
        {
            _candidateAppService = candidateAppService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var CandidatesRecruitmentPhaseDtoVM = _mapper.Map<IEnumerable<CandidateRecruitmentPhaseDto>, IEnumerable<CandidateRecruitmentPhaseDtoVM>>(await _candidateAppService.GetCandidatesRecruitmentPhases());
            return View(CandidatesRecruitmentPhaseDtoVM);
        }
    }
}
