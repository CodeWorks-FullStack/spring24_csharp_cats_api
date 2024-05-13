
public class CatsRepository
{

  private readonly IDbConnection _db;

  public CatsRepository(IDbConnection db)
  {
    _db = db;
  }

  internal List<Cat> GetAllCats()
  {
    string sql = "SELECT * FROM cats;";

    // Node equivalent: dbContext.Cats.find()
    List<Cat> cats = _db.Query<Cat>(sql).ToList();

    return cats;
  }
}