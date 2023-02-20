using AutoMapper;
using ElsysConnect.Application.Interfaces;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Web.Models.ElsysConnectModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

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
        
        // GET: CandidateController
        public async Task<ActionResult> Index()
        {           
            
            var candidates = await _candidateAppService.GetAllAsync();
            var candidatesViewModels = _mapper.Map<IEnumerable<Candidate>, IEnumerable<CandidateViewModel>>(candidates);
            return View(candidatesViewModels);
        }

        #region MyRegion
        // GET: CandidateController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CandidateController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CandidateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
        public ActionResult Delete(int id)
        {
            return View();
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
