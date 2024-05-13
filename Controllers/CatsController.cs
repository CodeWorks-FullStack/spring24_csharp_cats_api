// Creates package of public declared types in this file, and makes it accessible to other modules
namespace csharp_cats_api.Controllers;

[ApiController]
// Node Equivalent: super('api/cats')
[Route("api/cats")]

// Node equivalent: export class CatsController extends BaseController
public class CatsController : ControllerBase
{

  private readonly CatsService _catsService;

  public CatsController(CatsService catsService)
  {
    _catsService = catsService;
  }



  // Node equivalent: .get('/test', this.TestGet)
  [HttpGet("test")]
  public ActionResult<string> TestGet()
  {
    return Ok("API WORKS!");
  }


  [HttpGet]
  public ActionResult<List<Cat>> GetAllCats()
  {
    try
    {
      // const cats = await catsService.getCats()
      List<Cat> cats = _catsService.GetAllCats();

      // response.send(cats)
      return Ok(cats);
    }
    catch (Exception error)
    {
      // Node equivalent: next(error)
      return BadRequest(error.Message);
    }
  }
}