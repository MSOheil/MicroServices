namespace CommandService.Controllers;

[Route("api/c/[controller]")]
[ApiController]
public class PlatformsController:   ControllerBase
{
    public PlatformsController() {}
    [Route("TestConnection")]
    [HttpPost]
    public ActionResult TestInboundedConntection()
    {
        Console.WriteLine("===> Inbounded post command service");

        return Ok("Inbounded post from platforms controller");
    }
}