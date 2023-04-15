using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Alumnisystem.App.Shared;

namespace Alumnisystem.App.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class RoleApplicationController : ControllerBase
{
    private readonly ILogger<RoleApplicationController> _logger;

    public RoleApplicationController(ILogger<RoleApplicationController> logger)
    {
        _logger = logger;
    }

    /*[HttpGet("{RoleApplicationId}/RoleApplication")]
    public RoleApplication GetRoleApplicationbyID(int RoleApplicationId)
    {
        //return [RoleApplicationId];
    }*/
}