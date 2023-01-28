using EmployeeSystem.Aplication.Messages;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class GetCompanyByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetCompanyById/";


        public int Id { get; set; }
    }
}
