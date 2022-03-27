using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace kirvcore.Controllers;
[ApiController]
[Route("[controller]")]
public class BaseController : ControllerBase
{
    private readonly ILogger<BaseController> _logger;

    public BaseController(ILogger<BaseController> logger)
    {
        _logger = logger;
    }

}
