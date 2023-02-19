using AutoMapper;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Web.Models.ElsysConnectModel;

namespace App.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {

            #region ModelToDomain

            CreateMap<CandidateViewModel, Candidate>();


            #endregion

            #region DomainToModel

            CreateMap<Candidate, CandidateViewModel>();
            


            #endregion
        }
    }
}
