

namespace PlatFormService.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PlatfromServicesController : ControllerBase
{
    private readonly IPlatfromQueryService _platformQueryService;
    private readonly IPlatfromCommandService _platformCommandService;
    private readonly IMapper _mapper;
    public PlatfromServicesController(IPlatfromQueryService platformQueryService, IMapper mapper
        , IPlatfromCommandService platformCommandService)
    {
        this._platformQueryService = platformQueryService;
        this._mapper = mapper;
        this._platformCommandService = platformCommandService;

    }
    [Route("/GetAllPlatforms")]
    [HttpGet]
    public ActionResult<IEnumerable<PlatformReadDto>> GetAllPlatforms()
    {
        var allPlatform = _platformQueryService.GetAllPlatfomrs();
        return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(allPlatform));
    }
    [Route("/platformbyid/{platformId}")]
    [HttpGet]
    public ActionResult<PlatformReadDto> GetPlatformById(int platformId)
    {
        var platform = _platformQueryService.GetPlatformById(platformId);
        return Ok(_mapper.Map<PlatformReadDto>(platform));
    }
    [Route("/CreatPlatform")]
    [HttpPost]
    public IActionResult CreatePlatform(PlatformCreateDto platform)
    {
        _platformCommandService.CreatePlatfrom(_mapper.Map<Platform>(platform));
        return StatusCode(201);
    }
    [Route("/Ping")]
    [HttpGet]
    public ActionResult Ping()
    {
        return Ok("Pong");
    }
}