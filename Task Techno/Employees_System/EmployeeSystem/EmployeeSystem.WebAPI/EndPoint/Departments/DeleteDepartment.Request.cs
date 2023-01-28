using EmployeeSystem.Aplication.Messages;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Departments
{
    public class DeleteDepartmentEndPointRequest : BaseRequest
    {
        public const string Route = "/api/DeleteDepartment/";

        public int Id { get; set; }
    }
}
