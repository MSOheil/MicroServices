
namespace Application.Common.InterFaces.DbContext;
public interface IAppDbContext
{
     DbSet<Platform> Platforms { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
