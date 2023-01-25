using AutoMapper;
using EmployeeSystem.Aplication.Business.Companies.Command;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.API.EndPoints.Companies
{
    public class CreateCompanyMapper : Profile
    {
        public CreateCompanyMapper()
        {
            CreateMap<CreateCompanyEndPointRequest, CreateCompanyHandlerInput>()
                .ConstructUsing(src => new CreateCompanyHandlerInput(src.CorrelationId()));
            CreateMap<CreateCompanyHandlerOutput, CreateCompanyEndPointResponse>()
               .ConstructUsing(src => new CreateCompanyEndPointResponse(src.CorrelationId()));
        }

    }
}
