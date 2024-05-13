// Creates package of public declared types in this file, and makes it accessible to other modules
namespace csharp_cats_api.Controllers;

[ApiController]
// Node Equivalent: super('api/cats')
[Route("api/cats")]

// Node equivalent: export class CatsController extends BaseController
public class CatsController : ControllerBase
{
  // Node equivalent: .get('/test', this.TestGet)
  [HttpGet("test")]
  public ActionResult<string> TestGet()
  {
    return Ok("API WORKS!");
  }


}