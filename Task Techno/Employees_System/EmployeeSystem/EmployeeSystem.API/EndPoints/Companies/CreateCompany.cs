using Ardalis.ApiEndpoints;
using AutoMapper;
using EmployeeSystem.Aplication.Business.Companies.Command;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System.Net;

namespace EmployeeSystem.API.EndPoints.Companies
{
    public class CreateCompanyEndPoint : EndpointBaseAsync
    .WithRequest<CreateCompanyEndPointRequest>
    .WithActionResult<CreateCompanyEndPointResponse>
    {
        private readonly ILogger<CreateCompanyEndPoint> _logger;
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;
        public CreateCompanyEndPoint(ILogger<CreateCompanyEndPoint> logger, IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _logger = logger;
            _mapper = mapper;

        }
        //[Authorize]
        [HttpPost(CreateCompanyEndPointRequest.Route)]
        //[SwaggerOperation(Summary = "CreateCompany", Description = "CreateCompany ", OperationId = "EmployeeSystem.API.EndPoints.Companies.CreateCompany", Tags = new[] { "EmployeeSystem.API.EndPoints.Companies" })]
        [Produces("application/json")]
       // [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(CreateCompanyEndPointResponse))]
       // [SwaggerResponse((int)HttpStatusCode.BadRequest, Type = typeof(Exception))]
        public override async Task<ActionResult<CreateCompanyEndPointResponse>> HandleAsync([FromBody] CreateCompanyEndPointRequest request, CancellationToken cancellationToken = default)
        {
            _logger.LogInformation("Information : Starting CreateCompany handling");
            var Appinput = _mapper.Map<CreateCompanyHandlerInput>(request);
            var result = await _mediator.Send(Appinput, cancellationToken);

            return Ok(_mapper.Map<CreateCompanyEndPointResponse>(result));
        }
    }
}
