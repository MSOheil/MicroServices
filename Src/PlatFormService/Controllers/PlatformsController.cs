

namespace PlatFormService.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PlatfromServicesController : ControllerBase
{
    private readonly IPlatfromQueryService _platformQueryService;
    private readonly IPlatfromCommandService _platformCommandService;
    private readonly ICommandDataClientService _commandDataClientService;
    private readonly IMapper _mapper;
    public PlatfromServicesController(IPlatfromQueryService platformQueryService, IMapper mapper
        , IPlatfromCommandService platformCommandService, ICommandDataClientService commandDataClientService)
    {
        this._platformQueryService = platformQueryService;
        this._mapper = mapper;
        this._platformCommandService = platformCommandService;
        this._commandDataClientService = commandDataClientService;
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
    public async Task<IActionResult> CreatePlatform(PlatformCreateDto platform)
    {
        var platFormReadDto = _mapper.Map<Platform>(platform);
        _platformCommandService.CreatePlatfrom(platFormReadDto);
      await  _commandDataClientService.SendPlatformToCommand(platform);
        return StatusCode(201);
    }
    [Route("/Ping")]
    [HttpGet]
    public ActionResult Ping() => Ok("Pong");
}