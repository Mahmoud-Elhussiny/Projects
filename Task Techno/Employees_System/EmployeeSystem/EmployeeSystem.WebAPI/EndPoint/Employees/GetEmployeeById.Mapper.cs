using AutoMapper;
using EmployeeSystem.Aplication.Business.Employees.Quary;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class GetEmployeeByIdMapper : Profile
    {
        public GetEmployeeByIdMapper()
        {
            CreateMap<GetEmployeeByIdEndPointRequest, GetEmployeeByIdHandlerInput>()
                .ConstructUsing(src => new GetEmployeeByIdHandlerInput(src.CorrelationId()));
            CreateMap<GetEmployeeByIdHandlerOutput, GetEmployeeByIdEndPointResponse>()
               .ConstructUsing(src => new GetEmployeeByIdEndPointResponse(src.CorrelationId()));
        }

    }
}
