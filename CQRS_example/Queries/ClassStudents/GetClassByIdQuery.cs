using CQRS_example.Models;
using MediatR;

namespace CQRS_example.Queries.ClassStudents
{
    public class GetClassByIdQuery : IRequest<Class>
    {
        public int Id { get; set; }
        public GetClassByIdQuery(int id)
        {
            Id = id;
        }
    }
}
