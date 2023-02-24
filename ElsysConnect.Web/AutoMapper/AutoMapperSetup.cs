using AutoMapper;
using ElsysConnect.Domain.Entities;
using ElsysConnect.Domain.Entities.Dtos;
using ElsysConnect.Web.Models.ElsysConnectModel;
using ElsysConnect.Web.Models.ElsysConnectModel.Dtos;

namespace ElsysConnect.Web.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {

            CreateMap<Candidate, CandidateViewModel>();
            CreateMap<CandidateRecruitmentPhaseDto, CandidateRecruitmentPhaseDtoVM>();
            CreateMap<PhasesDto, PhasesDtoVM>();
            //.IncludeBase<BaseEntity, BaseViewModel>() // include base mapping
            //.ReverseMap(); // two-way mapping

            // Mapping from CandidateViewModel to Candidate
            CreateMap<CandidateViewModel, Candidate>();
            //.IncludeBase<BaseViewModel, BaseEntity>() // include base mapping
            //.ReverseMap(); // two-way mapping

            CreateMap<JobPosition, JobPositionViewModel>();
            CreateMap<JobPositionViewModel, JobPosition>();
            CreateMap<CandidateRecruitmentPhaseDtoVM, CandidateRecruitmentPhaseDto>();
            CreateMap<PhasesDtoVM, PhasesDto>();


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
