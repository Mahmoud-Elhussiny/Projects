using EmployeeSystem.Aplication.Messages;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Employees
{
    public class GetAllEmployeesEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetAllEmployees/";
    }
}
