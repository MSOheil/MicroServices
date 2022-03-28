

namespace PlatFormService.InterFaces.DbContextInterFace.Services;
public interface IAppDbContext
{
     DbSet<Platform> Platforms { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
