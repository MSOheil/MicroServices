namespace Application.InterFaces;
public interface IPlatfromCommandService
{
    /// <summary>
    /// Create a new platform
    /// </summary>
    /// <param name="platform">platfrom object</param>
    void CreatePlatfrom(Platform platform);

}