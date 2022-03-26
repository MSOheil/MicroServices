

namespace Application.PlatformCQ.Query.GetAllPlatformQuery;

public class GetAllPlatformQuery : IRequest<IEnumerable<PlatformReadDto>>
{

}
public class GetAllPlatformQueryHandler : IRequestHandler<GetAllPlatformQuery, IEnumerable<PlatformReadDto>>
{
    private readonly IPlatfromQueryService _platfromQueryService;
    private readonly IMapper _mapper;
    public GetAllPlatformQueryHandler(IPlatfromQueryService platfromQueryService, IMapper mapper)
    {
        this._platfromQueryService = platfromQueryService;
        _mapper = mapper;
    }
    public Task<IEnumerable<PlatformReadDto>> Handle(GetAllPlatformQuery request, CancellationToken cancellationToken)
    {
        var platforms = _platfromQueryService.GetAllPlatfomrs();
        var mapData = _mapper.Map<IEnumerable<PlatformReadDto>>(platforms);
        return Task.FromResult(mapData);

    }
}
