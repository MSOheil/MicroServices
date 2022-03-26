namespace Application.Profiles;
public class PlatformProfile : Profile
{
    public PlatformProfile()
    {
        CreateMap<Platform, PlatformReadDto>().ReverseMap();
        CreateMap<Platform, PlatformCreateDto>().ReverseMap();
    }
}
