using CQRS_example.Models;
using MediatR;

namespace CQRS_example.Queries.Students
{
    public class GetStudentListQuery : IRequest<List<Student>>
    {
    }
}
