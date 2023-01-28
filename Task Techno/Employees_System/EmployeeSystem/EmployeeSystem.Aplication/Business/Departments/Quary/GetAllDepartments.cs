﻿using EmployeeSystem.Aplication.Business.Companies.Quary;
using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Departments.Quary
{
    public class GetAllDepartmentsHandler : IRequestHandler<GetAllDepartmentsHandlerInput, GetAllDepartmentsHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAllDepartmentsHandler> _logger;
        public GetAllDepartmentsHandler(ILogger<GetAllDepartmentsHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAllDepartmentsHandlerOutput> Handle(GetAllDepartmentsHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAllDepartments business logic");
            GetAllDepartmentsHandlerOutput output = new GetAllDepartmentsHandlerOutput(request.CorrelationId());

            var allDeparts = await _databaseService.Departments.Select(o => new AllDeparts
            {
                Id = o.Id,
                Name = o.Name,
                CompanyId = o.CompanyId

            }).ToListAsync(cancellationToken);

            output.allDeparts = allDeparts;

            return output;
        }
    }
}
