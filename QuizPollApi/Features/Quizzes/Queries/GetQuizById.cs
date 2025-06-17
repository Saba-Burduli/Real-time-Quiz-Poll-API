namespace QuizPollApi.Features.Quizzes.Queries;

public class GetQuizById
{
    public record GetQuizById(QuizId QuizId) : IRequest<Quiz>;
}