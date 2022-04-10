using AutoMapper;
using CommandService.Dto;
using CommandService.models;
using CommandService.Models;

namespace CommandService.Profiles
{
    public class CommandProfiles : Profile

    {
        public CommandProfiles()
        {
            CreateMap<Platform, PlatformReadDto>().ReverseMap();
            CreateMap<CreateCommandDto, Command>().ReverseMap();
        }
    }
}
