using EmployeeSystem.Aplication.Messages;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class GetEmployeeByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetEmployeeById/";


        public int Id { get; set; }

    }
}
