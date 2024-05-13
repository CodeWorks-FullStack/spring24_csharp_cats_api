
namespace csharp_cats_api.Services;

// NOTE service is now responsible for all business logic
public class CatsService
{
  private readonly CatsRepository _repository;

  public CatsService(CatsRepository repository)
  {
    _repository = repository;
  }


  // internal and public can be used interchangeably in the service for access modifier of methods
  internal List<Cat> GetAllCats()
  {
    List<Cat> cats = _repository.GetAllCats();
    return cats;
  }
}