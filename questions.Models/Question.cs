using System;

namespace questions.Models
{
  public class Question
  {
    public int Id { get; set; }
    public string Content { get; set; }
    public int Number { get; set; }
    public int SubjectId { get; set; }
    public int ExamId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime DeletedAt { get; set; }
  }
}
