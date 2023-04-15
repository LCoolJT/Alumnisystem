using Alumnisystem.App.Shared.RoleApplication.cs;

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

    [HttpGet("{RoleApplicationId}/RoleApplication")]
    public RoleApplication GetRoleApplicationbyID(int RoleApplicationId)
    {
        return [RoleApplicationId];
    }
}