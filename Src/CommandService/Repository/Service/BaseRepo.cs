using CommandService.Data;
using CommandService.Dto;
using CommandService.models;
using CommandService.Models;
using System.Collections;

namespace CommandService.Repository.Service
{
    public class BaseRepo : IBaseRepo
    {
        private readonly AppDbContext _db;
        public BaseRepo(AppDbContext db)
        {
            _db = db;
        }

        public bool CheckExistsPlatform(int id)
            => _db.Platforms.Any(a => a.Id.Equals(id));

        public void CreateCommand(int platformId, CreateCommandDto dto)
        {
            var db = _db.Platforms.Find(platformId);
            db.Commands = new Command
            {
                CommandLine = dto.CommandLine,
                HowTo = dto.HowTo,
            };
            _db.SaveChanges();
        }

        public void CreatePlatform(Platform model)
            => _db.Platforms.Add(model);

        public IEnumerable<Platform> FindByIdPlatform(int id)
            => _db.Platforms.Find(id);

        public System.Collections.Generic.IEnumerable GetAllPlatforms()
            => _db.Platforms.ToList();

        public IEnumerable<Command> GetCommandByPlatformId(int commandId, int platformId)
        {
            var s = _db.Platforms.Where(a => a.Id.Equals(platformId)).Select(a => a.Commands);

        }

        public bool SaveChanges() => _db.SaveChanges() > 0;

    }
}
