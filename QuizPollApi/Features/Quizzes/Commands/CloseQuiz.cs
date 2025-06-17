using MediatR;
using Microsoft.AspNet.SignalR;
using QuizPollApi.Infrastructure.Persistence;
using QuizPollApi.Infrastructure.SignalR;
using IRequest = Microsoft.AspNet.SignalR.IRequest;

namespace QuizPollApi.Features.Quizzes.Commands;

public class CloseQuiz
{
    public record Close(QuizId QuizId) : IRequest;
}