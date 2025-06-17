namespace QuizPollApi.Entities;

public class Response
{
    public Guid Id { get; set; }
    public Guid QuizId { get; set; }
    public Guid QuestionId { get; set; }
    public string UserId { get; set; } // null for anonymous
    public List<string> SelectedOptions { get; set; }
    public DateTime Timestamp { get; set; }
    public string IPAddress { get; set; }}