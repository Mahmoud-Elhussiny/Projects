using AutoMapper;
using EmployeeSystem.Aplication.Business.Employees.Command;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class CreateEmployeeMapper : Profile
    {
        public CreateEmployeeMapper()
        {
            CreateMap<CreateEmployeeEndPointRequest, CreateEmployeeHandlerInput>()
                .ConstructUsing(src => new CreateEmployeeHandlerInput(src.CorrelationId()));
            CreateMap<CreateEmployeeHandlerOutput, CreateEmployeeEndPointResponse>()
               .ConstructUsing(src => new CreateEmployeeEndPointResponse(src.CorrelationId()));
        }

    }
}
