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

            #region DomainToModel

            CreateMap<Candidate, CandidateViewModel>();
            CreateMap<JobPosition, JobPositionViewModel>();
            CreateMap<CandidateRecruitmentPhaseDto, CandidateRecruitmentPhaseDtoVM>();
            CreateMap<PhasesDto, PhasesDtoVM>();

            #endregion

            #region ModelToDomain

            CreateMap<CandidateViewModel, Candidate>();
            CreateMap<JobPositionViewModel, JobPosition>();
            CreateMap<CandidateRecruitmentPhaseDtoVM, CandidateRecruitmentPhaseDto>();
            CreateMap<PhasesDtoVM, PhasesDto>();

            #endregion
        }
    }
}
