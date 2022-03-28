

namespace PlatFormService.InterFaces.Services;
public class PlatfromCommandService : IPlatfromCommandService
{
    private readonly IAppDbContext _dbContext;
    public PlatfromCommandService(IAppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public void CreatePlatfrom(Platform platform)
    {
        if (platform is null) new ArgumentNullException(nameof(platform));
        _dbContext.Platforms.Add(platform);
    }
}
