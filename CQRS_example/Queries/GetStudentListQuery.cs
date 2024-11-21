using CQRS_example.Models;
using MediatR;

namespace CQRS_example.Queries
{
    public class GetStudentListQuery : IRequest<List<Student>>
    {
    }
}
