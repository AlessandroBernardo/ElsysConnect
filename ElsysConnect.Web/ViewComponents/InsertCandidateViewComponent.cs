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
        public async Task<IViewComponentResult> InvokeAsync()
        {           
            return View();
        }
    }
}
