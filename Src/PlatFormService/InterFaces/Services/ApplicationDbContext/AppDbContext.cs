namespace PlatFormService.InterFaces.Services.ApplicationDbContext;

public class AppDbContext : DbContext, IAppDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
    {
    }

    public DbSet<Platform> Platforms { get; set; }


    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        var result = await base.SaveChangesAsync(cancellationToken);
        return result;
    }
}
