namespace PlatFormService.InterFaces.SyncData;

public interface ICommandDataClientService
{
    Task SendPlatformToCommand(PlatformCreateDto platform);
}


