using System;

namespace questions.Models
{
  public class Category
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpatedAt { get; set; }
    public bool IsDeletd { get; set; }
    public DateTime DeletedAt { get; set; }
  }
}
