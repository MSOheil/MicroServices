using CommandService.models;
using CommandService.Models.Common;

namespace CommandService.Models;
public class Platform:BaseModel
{
    public int Id { get; set; }
    public int ExternalId { get; set; }
    public string Nmae { get; set; }
    public IList<Command> Commands { get; set; } = new List<Command>();
}