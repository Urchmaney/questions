using System;

namespace questions.Models
{
  public class Option
  {
    public int Id { get; set; }
    public string Content { get; set; }
    public int SubjectId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
  }
}
