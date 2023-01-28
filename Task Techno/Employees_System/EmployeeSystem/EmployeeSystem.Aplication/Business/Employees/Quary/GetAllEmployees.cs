using EmployeeSystem.Aplication.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeSystem.Aplication.Business.Employees.Quary
{
    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesHandlerInput, GetAllEmployeesHandlerOutput>
    {
        private readonly IDatabaseService _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<GetAllEmployeesHandler> _logger;
        public GetAllEmployeesHandler(ILogger<GetAllEmployeesHandler> logger, IDatabaseService databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<GetAllEmployeesHandlerOutput> Handle(GetAllEmployeesHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling GetAllEmployees business logic");
            GetAllEmployeesHandlerOutput output = new GetAllEmployeesHandlerOutput(request.CorrelationId());
            
            var allemployees = await _databaseService.Employees
                .Include(o=>o.Departments)
                .Select(o=> new AllEmployees
            {
                Id = o.Id,
                Name = o.Name,
                UserName = o.UserName,
                password = o.password,
                address = o.address
            }).ToListAsync(cancellationToken);

            output.allEmployees = allemployees;

            return output;
        }
    }
}
