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
    public class TesteViewComponent : ViewComponent
    {

        private readonly IJobPositionAppService _jobPositionAppService;
        private readonly IMapper _mapper;

        public TesteViewComponent(IJobPositionAppService jobPositionAppService, IMapper mapper)
        {
            _jobPositionAppService = jobPositionAppService;
            _mapper = mapper;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var jobViewModels = _mapper.Map<IEnumerable<JobPosition>, IEnumerable<JobPositionViewModel>>(await _jobPositionAppService.GetAllAsync());
            return View(jobViewModels);
        }
    }
}
