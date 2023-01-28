using AutoMapper;
using EmployeeSystem.Aplication.Business.Companies.Quary;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class GetCompanyByIdMapper : Profile
    {
        public GetCompanyByIdMapper()
        {
            CreateMap<GetCompanyByIdEndPointRequest, GetCompanyByIdHandlerInput>()
                .ConstructUsing(src => new GetCompanyByIdHandlerInput(src.CorrelationId()));
            CreateMap<GetCompanyByIdHandlerOutput, GetCompanyByIdEndPointResponse>()
               .ConstructUsing(src => new GetCompanyByIdEndPointResponse(src.CorrelationId()));
        }

    }
}
