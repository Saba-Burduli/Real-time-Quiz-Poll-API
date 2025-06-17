namespace QuizPollApi.Features.Quizzes.Commands;

public class UpdateQuiz
{
    public record UpdateQuiz(QuizId Id, string Title, ICollection<QuestionId> QuestionIds) : IRequest<Quiz>;
}