using AutoMapper;
using EmployeeSystem.Aplication.Business.Companies.Command;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class UpdateCompanyMapper : Profile
    {
        public UpdateCompanyMapper()
        {
            CreateMap<UpdateCompanyEndPointRequest, UpdateCompanyHandlerInput>()
                .ConstructUsing(src => new UpdateCompanyHandlerInput(src.CorrelationId()));
            CreateMap<UpdateCompanyHandlerOutput, UpdateCompanyEndPointResponse>()
               .ConstructUsing(src => new UpdateCompanyEndPointResponse(src.CorrelationId()));
        }

    }
}
