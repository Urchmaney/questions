using System;
using System.Collections;

namespace questions.Models
{
  public class Subject
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletdAt { get; set; }
    public IEnumerable<Option> Options { get; set;}
  }
}
