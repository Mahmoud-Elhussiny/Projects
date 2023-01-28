using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Departments.Command;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class DeleteDepartmentEndPoint : EndpointBaseAsync
    .WithRequest<DeleteDepartmentEndPointRequest>
    .WithActionResult<DeleteDepartmentEndPointResponse>
    {
        private readonly ILogger<DeleteDepartmentEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public DeleteDepartmentEndPoint(ILogger<DeleteDepartmentEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpDelete(DeleteDepartmentEndPointRequest.Route)]
        [SwaggerOperation(Summary = "DeleteDepartment", Description = "DeleteDepartment ", OperationId = "EmployeeSystem.WebAPI.EndPoint.Departments.DeleteDepartment", Tags = new[] { "EmployeeSystem.WebAPI.EndPoint.Departments" })]
        [Produces("application/json")]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(DeleteDepartmentEndPointResponse))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        public override async Task<ActionResult<DeleteDepartmentEndPointResponse>> HandleAsync([FromQuery] DeleteDepartmentEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting DeleteDepartment handling");
            var Appinput = _mapper.Map<DeleteDepartmentHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<DeleteDepartmentEndPointResponse>(result));
        }
    }
}
