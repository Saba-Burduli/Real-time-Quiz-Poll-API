using Domain.Entities.Questions;
using Domain.Entities.Quizzes;

namespace Domain.Repository;

public interface IQuestionRepository
{
    Task<ICollection<Question>> GetAllQuestion(string sortColumn, string? sortOrder, int page, int pageSize, string? prompt, QuizId? quizId);
    Task<ICollection<Question>> GetQuestionsByIds(ICollection<QuestionId> questionIds);
    Task<Question> CreateQuestion(Question toCreate);
    Task<Question> UpdateQuestion(QuestionId questionId);
    Task DelateQuestion(QuestionId questionId);
}