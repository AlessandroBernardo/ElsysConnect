using AutoMapper;
using ElsysConnect.Application.Interfaces;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Web.Models.ElsysConnectModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElsysConnect.Web.ViewComponents
{
    public class ListJobsViewComponent : ViewComponent
    {

        private readonly IJobPositionAppService _jobPositionAppService;
        private readonly IMapper _mapper;

        public ListJobsViewComponent(IJobPositionAppService jobPositionAppService, IMapper mapper)
        {
            _jobPositionAppService = jobPositionAppService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var candidateVm = new CandidateViewModel();
            ViewBag.Candidate = candidateVm;
            var jobViewModels = _mapper.Map<IEnumerable<JobPosition>, IEnumerable<JobPositionViewModel>>(await _jobPositionAppService.GetAllAsync());
            return View(jobViewModels);
        }

        
    }
}
