



namespace PlatFormService.ApplicationDbContext.Configuration.PlatformConfiguration;

public class PlatformConfig : IEntityTypeConfiguration<Platform>
{
    public void Configure(EntityTypeBuilder<Platform> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => new { a.Name, a.Publisher, a.Cost }).IsRequired();
    }
}
