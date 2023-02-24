using AutoMapper;
using ElsysConnect.Application.Interfaces;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Entities.Dtos;
using ElsysConnect.Web.Models.ElsysConnectModel;
using ElsysConnect.Web.Models.ElsysConnectModel.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using X.PagedList;

namespace ElsysConnect.Web.Controllers
{
    public class CandidateController : Controller
    {
        private readonly ICandidateAppService _candidateAppService;
        private readonly IMapper _mapper;

        public CandidateController(ICandidateAppService candidateAppService, IMapper mapper)
        {
            _candidateAppService = candidateAppService;
            _mapper = mapper;

        }

        [HttpGet]        
        public async Task<ActionResult> CandidatesRecruitmentPhases() {

            var candidatesRecruitmentPhaseDtoVM = _mapper.Map<IEnumerable<CandidateRecruitmentPhaseDto>, IEnumerable<CandidateRecruitmentPhaseDtoVM>>(await _candidateAppService.GetCandidatesRecruitmentPhases());
            return View(candidatesRecruitmentPhaseDtoVM);

        }

        // GET: CandidateController
        public async Task<ActionResult> Index(int? page)
        {
            int pageSize = 2;
            int pageNumber = (page ?? 1);
            
            var candidatesViewModels = _mapper.Map<IEnumerable<Candidate>, IEnumerable<CandidateViewModel>>(await _candidateAppService.GetAllAsync());
            var candidatesPerPage = candidatesViewModels.ToPagedList(pageNumber, pageSize);
            return View(candidatesPerPage);
        }

        #region MyRegion
        // GET: CandidateController/Details/5
        public ActionResult Details(Guid id)
        {
            return View();
        }

        // GET: CandidateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([FromForm] CandidateViewModel candidateViewModel)
        {
            await _candidateAppService.InsertAsync(_mapper.Map<CandidateViewModel, Candidate>(candidateViewModel));
            return RedirectToAction(nameof(Index));
        }

        // POST: CandidateController/Create
        //[HttpPost                                                                                                 
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: CandidateController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CandidateController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CandidateController/Delete/5

        public async Task<IActionResult> Delete(Guid id)
        {
            var candidate = await _candidateAppService.GetByIdAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }
            await _candidateAppService.DeleteAsync(candidate.Id);
            return RedirectToAction(nameof(Index));
        }


        // POST: CandidateController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}
