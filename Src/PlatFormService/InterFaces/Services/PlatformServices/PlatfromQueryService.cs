

namespace PlatFormService.InterFaces.Services;
public class PlatfromQueryService : IPlatfromQueryService
{
    private readonly IAppDbContext _dbContext;
    public PlatfromQueryService(IAppDbContext dbContext)
    {
        this._dbContext = dbContext;
    }

    public IEnumerable<Platform> GetAllPlatfomrs() => _dbContext.Platforms.ToList();

    public Platform GetPlatformById(int platformId) => _dbContext.Platforms.FirstOrDefault(a => a.Id.Equals(platformId));
}
