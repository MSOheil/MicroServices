using AutoMapper;
using CommandService.Dto;
using CommandService.Repository;

namespace CommandService.Controllers;

[Route("api/c/[controller]")]
[ApiController]
public class PlatformsController : ControllerBase
{
    private readonly IBaseRepo _baseRepo;
    private readonly IMapper _mapper;
    public PlatformsController(IBaseRepo baseRepo, IMapper mapper)
    {
        _baseRepo = baseRepo;
        _mapper = mapper;
    }
    [HttpGet]
    public ActionResult<IEnumerable<PlatformReadDto>> GetAllPlatforms()
    {

        var platforms = _baseRepo.GetAllPlatforms();

        return Ok(_mapper.Map<PlatformReadDto>(platforms));
    }

    [Route("TestConnection")]
    [HttpPost]
    public ActionResult TestInboundedConntection()
    {
        Console.WriteLine("===> Inbounded post command service");

        return Ok("Inbounded post from platforms controller");
    }
}