using Job_App_Rest.Dto;
using Job_App_Rest.Models;
using Mapster;

namespace Job_App_Rest.Mapping
{
    public class MappingProfile : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.ForType<CompanyReqDto, Company>()
                .Ignore(dest => dest.Id);

            config.ForType<JobReqDto,Job>()
                .Ignore(dest => dest.Id);

            config.ForType<CreateJobReqDto, Job>()
                .Ignore(dest => dest.Id);

            config.ForType<CompanyDto, Company>()
                .Ignore(dest => dest.Id);
        }
    }
}
