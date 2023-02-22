using AutoMapper;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Web.Models.ElsysConnectModel;

namespace ElsysConnect.Web.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {

            CreateMap<Candidate, CandidateViewModel>();
            //.IncludeBase<BaseEntity, BaseViewModel>() // include base mapping
            //.ReverseMap(); // two-way mapping

            // Mapping from CandidateViewModel to Candidate
            CreateMap<CandidateViewModel, Candidate>();
            //.IncludeBase<BaseViewModel, BaseEntity>() // include base mapping
            //.ReverseMap(); // two-way mapping

            CreateMap<JobPosition, JobPositionViewModel>();
            CreateMap<JobPositionViewModel, JobPosition>();


            #region ModelToDomain

            //CreateMap<BaseViewModel, BaseEntity>();
            //CreateMap<CandidateViewModel, Candidate>();

            //#endregion

            //#region DomainToModel

            //CreateMap<BaseEntity, BaseViewModel>();
            //CreateMap<Candidate, CandidateViewModel>();

            #endregion
        }
    }
}
