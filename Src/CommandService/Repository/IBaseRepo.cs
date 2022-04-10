using CommandService.Dto;
using CommandService.models;
using CommandService.Models;
using System.Collections;

namespace CommandService.Repository
{
    public interface IBaseRepo
    {
        IEnumerable GetAllPlatforms();
        void CreatePlatform(Platform model);
        bool CheckExistsPlatform(int id);
        bool SaveChanges();
        IEnumerable FindByIdPlatform(int id);
        IEnumerable<Command> GetCommandByPlatformId(int commandId, int platformId);
        void CreateCommand(int platformId, CreateCommandDto dto);
    }
}
