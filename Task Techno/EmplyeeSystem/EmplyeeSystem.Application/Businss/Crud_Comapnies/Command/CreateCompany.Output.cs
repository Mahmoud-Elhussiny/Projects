
using EmplyeeSystem.Application.Message;

namespace EmplyeeSystem.Application.Businss.Crud_Comapnies.Command
{
    public class CreateCompanyHandlerOutput : BaseResponse
    {
        public CreateCompanyHandlerOutput() { }
        public CreateCompanyHandlerOutput(Guid correlationId) : base(correlationId) { }

    }
}
