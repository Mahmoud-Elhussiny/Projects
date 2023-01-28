using EmployeeSystem.Aplication.Messages;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class GetAllCompaniesEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetAllCompanies/";
    }
}
