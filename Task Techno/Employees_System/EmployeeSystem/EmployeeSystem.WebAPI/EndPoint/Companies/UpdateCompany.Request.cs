﻿using EmployeeSystem.Aplication.Messages;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.WebAPI.EndPoint.Companies
{
    public class UpdateCompanyEndPointRequest : BaseRequest
    {
        public const string Route = "/api/UpdateCompany/";

        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
