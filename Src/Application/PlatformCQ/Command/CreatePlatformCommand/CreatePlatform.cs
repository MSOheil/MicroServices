namespace Application.PlatformCQ.Command.CreatePlatformCommand;

public class CreatePlatform:IRequest
{
    public PlatformCreateDto Platform { get; set; }


}
public class CreatePlatformHandler : IRequestHandler<CreatePlatform>
{
    private readonly IAppDbContext _dbContext;
    private readonly IPlatfromCommandService _platfromService;
    private readonly IMapper _mapper;
    public CreatePlatformHandler(IAppDbContext dbContext, IPlatfromCommandService platfromService
        , IMapper mapper)
    {
        _dbContext = dbContext;
        _platfromService = platfromService;
        _mapper = mapper;
    }

    public Task<Unit> Handle(CreatePlatform request, CancellationToken cancellationToken)
    {
        var platform = _mapper.Map<Platform>(request.Platform);
        _platfromService.CreatePlatfrom(platform);
        _dbContext.SaveChangesAsync(cancellationToken);
        return Task.FromResult(Unit.Value);
    }
}
