﻿using EmployeeSystem.Aplication.Messages;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeSystem.API.EndPoints.Companies
{
    public class CreateCompanyEndPointRequest : BaseRequest
    {

        public const string Route = "/api/CreateCompany/";

        public string Name { get; set; }
    }
}