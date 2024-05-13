namespace csharp_cats_api.Repositories;


public class CatsRepository
{

  private readonly IDbConnection _db;

  public CatsRepository(IDbConnection db)
  {
    _db = db;
  }

  internal Cat CreateCat(Cat catData)
  {
    // REVIEW allows sql injection attacks
    // string badSql = @$"
    // INSERT INTO 
    // cats(age, color, hasPolydactylity, name) 
    // VALUES({catData.Age}, '{catData.Color}', {catData.HasPolydactylity}, '{catData.Name}');";

    // @ denotes that dapper will look through our object and pull the values out
    string sql = @"
    INSERT INTO 
    cats(name, age, color, hasPolydactylity) 
    VALUES(@Name, @Age, @Color, @HasPolydactylity);
    
    SELECT * FROM cats WHERE id = LAST_INSERT_ID();";

    Cat cat = _db.Query<Cat>(sql, catData).FirstOrDefault(); // return the first row found, or return null

    return cat;
  }

  internal List<Cat> GetAllCats()
  {
    string sql = "SELECT * FROM cats;";

    // Node equivalent: dbContext.Cats.find()
    List<Cat> cats = _db.Query<Cat>(sql).ToList();

    return cats;
  }

  internal Cat GetCatById(int catId)
  {
    string sql = "SELECT * FROM cats WHERE id = @catId;";

    //                                 {catId: 6}
    Cat cat = _db.Query<Cat>(sql, new { catId }).FirstOrDefault();

    return cat;
  }
}