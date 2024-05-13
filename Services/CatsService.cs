


namespace csharp_cats_api.Services;

// NOTE service is now responsible for all business logic
public class CatsService
{
  private readonly CatsRepository _repository;

  public CatsService(CatsRepository repository)
  {
    _repository = repository;
  }

  internal Cat CreateCat(Cat catData)
  {
    Cat cat = _repository.CreateCat(catData);
    return cat;
  }


  // internal and public can be used interchangeably in the service for access modifier of methods
  internal List<Cat> GetAllCats()
  {
    List<Cat> cats = _repository.GetAllCats();
    return cats;
  }

  internal Cat GetCatById(int catId)
  {
    Cat cat = _repository.GetCatById(catId);

    if (cat == null)
    {
      throw new Exception($"Invalid id: {catId}");
    }

    return cat;
  }
}