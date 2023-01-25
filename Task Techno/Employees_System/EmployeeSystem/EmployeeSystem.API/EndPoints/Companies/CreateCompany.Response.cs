
using EmployeeSystem.Aplication.Messages;

namespace EmployeeSystem.API.EndPoints.Companies
{
    public class CreateCompanyEndPointResponse : BaseRessponse
    {
        public CreateCompanyEndPointResponse() { }
        public CreateCompanyEndPointResponse(Guid correlationId) : base(correlationId) { }
        public string Messages { get; set; }
    }
}
