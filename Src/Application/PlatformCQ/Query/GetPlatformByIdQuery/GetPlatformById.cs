namespace Application.PlatformCQ.Query.GetPlatformByIdQuery;

public class GetPlatformById : IRequest<PlatformReadDto>
{
    public int PlatformId { get; set; }
}
public class GetPlatformByIdHandler : IRequestHandler<GetPlatformById, PlatformReadDto>
{
    private readonly IPlatfromQueryService _platfromQueryService;
    private readonly IMapper _mapper;
    public GetPlatformByIdHandler(IPlatfromQueryService platfromQueryService, IMapper mapper)
    {
        this._platfromQueryService = platfromQueryService;
        this._mapper = mapper;
    }


    public Task<PlatformReadDto> Handle(GetPlatformById request, CancellationToken cancellationToken)
    {
        var platform = _platfromQueryService.GetPlatformById(request.PlatformId);
        var mapData = _mapper.Map<PlatformReadDto>(platform);
        return Task.FromResult(mapData);

    }
}
