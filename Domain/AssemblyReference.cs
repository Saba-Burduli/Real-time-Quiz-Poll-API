using Domain.Entities.Questions;
using Domain.Models;

namespace Domain;

public class AssemblyReference : ValueObject
{
    public int QuestionNumber { get; set; }
    public string? Question { get; set; }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return QuestionNumber;
        yield return Question;
    }
}