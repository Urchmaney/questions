using System;

namespace questions.Models
{
  public class Exam
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
  }
}
