

using Application.PlatformCQ.Command.CreatePlatformCommand;

namespace PlatFormService.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PlatfromServicesController : ControllerBase
{
    private readonly IPlatfromQueryService _platforService;
    private readonly IMediator _mediator;
    public PlatfromServicesController(IPlatfromQueryService platforService, IMediator mediator)
    {
        _platforService = platforService;
        _mediator = mediator;
    }
    [Route("/GetAllPlatforms")]
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PlatformReadDto>>> GetAllPlatforms()
    {
        var allPlatforms = await _mediator.Send(new GetAllPlatformQuery());
        return Ok(allPlatforms);
    }
    [Route("/platformbyid/{platformId}")]
    [HttpGet]
    public ActionResult<PlatformReadDto> GetPlatformById(int platformId)
    {
        var platform = _mediator.Send(new GetPlatformById { PlatformId = platformId });
        return Ok(platform);
    }
    [Route("/CreatPlatform")]
    [HttpPost]
    public IActionResult CreatePlatform(PlatformCreateDto platform)
    {
        _mediator.Send(new CreatePlatform
        {
            Platform = platform
        });
        return StatusCode(201);
    }
    [Route("/Ping")]
    [HttpGet]
    public ActionResult Ping()
    {
        return Ok("Pong");
    }
}