namespace csharp_cats_api.Models;

public class Cat
{
  public int Id { get; set; }
  public string Name { get; set; }
  public int Age { get; set; }
  public bool HasPolydactylity { get; set; }
  private string Color { get; set; }
}