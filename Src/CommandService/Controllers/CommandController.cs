using AutoMapper;
using CommandService.Dto;
using CommandService.Repository;

namespace CommandService.Controllers
{
    [Route("api/v1/command")]
    [ApiController]
    public class CommandController : Controller
    {
        private readonly IBaseRepo _baseRepo;
        private readonly IMapper _mapper;
        public CommandController(IBaseRepo baseRepo
            , IMapper mapper)
        {
            _baseRepo = baseRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index(int platformId)
        {
            if (!_baseRepo.CheckExistsPlatform(platformId))
            {
                return NotFound();
            }

            var commands = _baseRepo.FindByIdPlatform(platformId);

            return Ok(_mapper.Map<IEnumerable<CommandReadDto>>(commands));

        }
        [HttpGet("{CommandId}", Name = "GetCommandByPlatformId")]
        public ActionResult<CommandReadDto> GetCommandByPlatformId(int platformId, int commandId)
        {
            if (!_baseRepo.CheckExistsPlatform(platformId))
            {
                return NotFound();
            }

            var command = _baseRepo.GetCommandByPlatformId(commandId, platformId);
            return Ok(command);
        }
        [HttpPost]
        public ActionResult<CommandReadDto> CreateCommandForPlatform(int platformId, CreateCommandDto dto)
        {
            var platform = _baseRepo.FindByIdPlatform(platformId);

            platform=new Platform
            {

            }
        }

    }
}
