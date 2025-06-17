namespace QuizPollApi.Features.Quizzes.Queries;

public class GetQuizzes
{
    
    public record GetAllQuizzes(
        string? SortColumn, 
        string? SortOrder, 
        int Page, 
        int PageSize, 
        string? Title) : IRequest<ICollection<Quiz>>;
}