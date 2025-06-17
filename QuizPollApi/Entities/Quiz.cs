namespace QuizPollApi.Entities;

public class Quiz
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Visibility { get; set; } // public/private
    public string AccessCode { get; set; }
    public bool IsPublished { get; set; }
    public DateTime? EndsAt { get; set; }
    public bool AllowAnonymous { get; set; }
    public List<Question> Questions { get; set; }  
}