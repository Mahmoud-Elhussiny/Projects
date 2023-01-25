using EmplyeeSystem.Application.Message;
using MediatR;

namespace EmplyeeSystem.Application.Businss.Crud_Comapnies.Command
{
    public class CreateCompanyHandlerInput : BaseRequest, IRequest<CreateCompanyHandlerOutput>
    {
        public CreateCompanyHandlerInput() { }
        public CreateCompanyHandlerInput(Guid correlationId) : base(correlationId) { }
    }

}
