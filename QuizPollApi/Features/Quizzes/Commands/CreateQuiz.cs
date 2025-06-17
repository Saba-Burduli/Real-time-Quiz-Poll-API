using MediatR;
using QuizPollApi.Entities;
using QuizPollApi.Infrastructure.Persistence;

namespace QuizPollApi.Features.Quizzes.Commands;

public class CreateQuiz
{
    public record CreateQuiz(string Title, ICollection<QuestionId> QuestionIds) : IRequest<Quiz>;
}