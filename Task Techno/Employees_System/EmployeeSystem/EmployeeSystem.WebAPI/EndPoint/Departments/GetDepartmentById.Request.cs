using EmployeeSystem.Aplication.Messages;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class GetDepartmentByIdEndPointRequest : BaseRequest
    {
        public const string Route = "/api/GetDepartmentById/";


        public int Id { get; set; }
    }
}
