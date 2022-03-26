namespace Application.InterFaces;
public interface IPlatfromQueryService
{
    /// <summary>
    /// Get all platforms
    /// </summary>
    /// <returns></returns>
    IEnumerable<Platform> GetAllPlatfomrs();
   /// <summary>
   /// Get all platfroms with id
   /// </summary>
   /// <param name="platformId">platform's Id</param>
   /// <returns></returns>
    Platform GetPlatformById(int platformId);


}