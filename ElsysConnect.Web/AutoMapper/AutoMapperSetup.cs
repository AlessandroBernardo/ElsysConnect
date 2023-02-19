using AutoMapper;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Web.Models.ElsysConnectModel;

namespace ElsysConnect.Web.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {

            #region ModelToDomain

            CreateMap<BaseViewModel, BaseEntity>();
            CreateMap<CandidateViewModel, Candidate>();

            #endregion

            #region DomainToModel
            
            CreateMap<BaseEntity, BaseViewModel>();
            CreateMap<Candidate, CandidateViewModel>();

            #endregion
        }
    }
}
