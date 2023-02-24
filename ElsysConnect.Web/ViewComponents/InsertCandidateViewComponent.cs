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
    public class InsertCandidateViewComponent : ViewComponent
    {

        //private readonly ICandidateAppService _candidateAppService;
        //private readonly IMapper _mapper;

        //public InsertCandidateViewComponent(ICandidateAppService candidateAppService, IMapper mapper)
        //{
            
            

        //}

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var canditateEntity = _mapper.Map<CandidateViewModel, Candidate>(candidateViewModel);
            //await _candidateAppService.InsertAsync(canditateEntity);
            
            //var jobViewModels = _mapper.Map<IEnumerable<JobPosition>, IEnumerable<JobPositionViewModel>>(await _jobPositionAppService.GetAllAsync());
            return View();
        }
    }
}
