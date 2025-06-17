namespace QuizPollApi.Entities;

public class Question
{
    public Guid Id { get; set; }
    public string Type { get; set; }
    public string Text { get; set; }
    public string ImageUrl { get; set; }
    public List<string> Options { get; set; }
}