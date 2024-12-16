using CQRS_example.Models;
using MediatR;

namespace CQRS_example.Queries.ClassStudents
{
    public class GetClassListQuery : IRequest<List<Class>>
    {
    }
}
