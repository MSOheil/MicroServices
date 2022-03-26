
namespace PlatFormService.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PlatfromServicesController : ControllerBase
{
    private readonly IPlatfromQueryService _platforService;
    private readonly IMediator _mediator;
    public PlatfromServicesController(IPlatfromQueryService platforService, IMapper mapper, IMediator mediator)
    {
        this._platforService = platforService;
        _mediator = mediator;
    }
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PlatformReadDto>>> GetAllPlatforms()
    {

        Mediator.Send()





        return Ok();
    }


}