using EmplyeeSystem.Application.Interface;
using EmplyeeSystem.domain;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmplyeeSystem.Application.Businss.Crud_Comapnies.Command
{
    public class CreateCompanyHandler : IRequestHandler<CreateCompanyHandlerInput, CreateCompanyHandlerOutput>
    {
        private readonly IAppDbContext _databaseService;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly ILogger<CreateCompanyHandler> _logger;
        public CreateCompanyHandler(ILogger<CreateCompanyHandler> logger, IAppDbContext databaseService, IHttpContextAccessor contextAccessor)
        {
            _logger = logger;
            _databaseService = databaseService;
            _contextAccessor = contextAccessor;
        }
        public async Task<CreateCompanyHandlerOutput> Handle(CreateCompanyHandlerInput request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Handling CreateCompany business logic");
            CreateCompanyHandlerOutput output = new CreateCompanyHandlerOutput(request.CorrelationId());

            var newcompany = new Companies();

            newcompany.Name = "asd";
            newcompany.location = "Assuit";
            


            _databaseService.Companies.Add(newcompany);

          await _databaseService.DBSaveChangesAsync(cancellationToken);

            return output;
        }
    }
}
