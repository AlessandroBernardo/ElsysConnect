using AutoMapper;
using ElsysConnect.Domain.Entities;

namespace App.AutoMapper
{
    public class AutoMapperSetup : Profile
    {
        public AutoMapperSetup()
        {

            #region ModelToDomain

            CreateMap<BaseViewModel, BaseEntity>();


            #endregion

            #region DomainToModel

            CreateMap<BaseEntity, BaseViewModel>();
            


            #endregion
        }
    }
}
