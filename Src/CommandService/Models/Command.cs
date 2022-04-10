using CommandService.Models;
using CommandService.Models.Common;

namespace CommandService.models;
public class Command : BaseModel 
{
    public string HowTo { get; set; }
    public string CommandLine { get; set; }
    public int PlatfomrId { get; set; }
    public Platform Platform { get; set; }

}