using EmployeeSystem.Aplication.Messages;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class GetAllDepartmentsEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetAllDepartments/";
    }
}
