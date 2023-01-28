using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Departments.Command;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class CreateDepartmentEndPoint : EndpointBaseAsync
    .WithRequest<CreateDepartmentEndPointRequest>
    .WithActionResult<CreateDepartmentEndPointResponse>
    {
        private readonly ILogger<CreateDepartmentEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public CreateDepartmentEndPoint(ILogger<CreateDepartmentEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpPost(CreateDepartmentEndPointRequest.Route)]
        [Produces("application/json")]
        public override async Task<ActionResult<CreateDepartmentEndPointResponse>> HandleAsync([FromBody] CreateDepartmentEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting CreateDepartment handling");
            var Appinput = _mapper.Map<CreateDepartmentHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<CreateDepartmentEndPointResponse>(result));
        }
    }
}
