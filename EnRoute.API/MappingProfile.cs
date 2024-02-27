using AutoMapper;
using EnRoute.API.Contracts.Auth.Requests;
using EnRoute.Infrastructure.Commands;

namespace EnRoute.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegisterRequest, RegisterCommand>();
            CreateMap<RegisterCompanyRequest, RegisterCommand>();
        }
    }
}
